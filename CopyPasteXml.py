import shutil
import os


def CopyPasteXml(origem, destino):
    for arquivo in os.listdir(origem):
            path = os.path.join(origem, arquivo)
            if os.path.isdir(path):
                CopyPasteXml(path, destino)
            else:
                extensao = os.path.splitext(arquivo)
                if(extensao[1] == '.xml'):
                    shutil.copyfile(os.path.join(origem, arquivo),
                                    os.path.join(destino, arquivo))


if __name__ == '__main__':
    if len(sys.argv) == 3:
        CopyPasteXml(sys.argv[1], sys.argv[2])
    else:
        print("You must enter the Origin and Destination path")
