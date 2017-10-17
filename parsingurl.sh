#!/bin/bash
if [ "$1" == "" ]
then
	echo "##################################"
	echo "Searching Hosts...."
	echo "$0 target.com.br"
	echo "##################################"
else
	wget $1 --quiet -O result
	grep href  result| cut -d "/" -f3 | grep "\." | cut -d '"' -f1 | sort -u | grep -v "<li" > list | xargs echo
	echo "###################################"
	echo "Searching Hosts...."
	echo "###################################"
	cat list
	echo "###################################"
	echo "Resolving Hosts...."
	echo "###################################"
	for url in $(cat list);do host $url; done | grep "has address"
fi
