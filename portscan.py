import socket
import sys


if (len(sys.argv) < 2):
    print("How to use portscan")
    print(sys.argv[0], "10.1.1.1")
else:
    for Port in range(1, 65535):
        mysocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        if (mysocket.connect_ex((sys.argv[1], Port)) == 0):
            print("Port ", Port, "[OPENED]")
