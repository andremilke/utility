import sys
import base64


class DecryptBase64(object):
    def __init__(self, _file, _filedest):
        self._file = _file
        self._filedest = _filedest

    def decryptBase64(self):
        try:
            rfile = open(_file)
            dic = {}
            for line in rfile:
                actual = line.rstrip("\n")
                arr = actual.split(";")
                dic[arr[0]] = base64.b64decode(arr[1])
            for key, value in sorted(dic.items()):
                dfile = open(_filedest, "a")
                dfile.writelines(key + ";" + value + "\n")
                dfile.close()
        except Exception as e:
            print(e.message)


if __name__ == "__main__":
    if len(sys.argv) == 3:
        _file = sys.argv[1]
        _filedest = sys.argv[2]
        decr = DecryptBase64(_file, _filedest)
        decr.decryptBase64()
    else:
        print("It is necessary to inform: file, file destiny")
