import hashlib as hasher
from types import MethodDescriptorType
from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from cryptography.hazmat.backends import default_backend
import base64
import sys
from twofish import Twofish

class dilKontrol:
    metin=""
    def __init__(self,metin):
        self.metin=metin

    def metinBelirle(self,metin):
        self.metin=metin

    def kelimeSayiBul(self):
        print("Metindeki kelime sayisi: "+str(len(self.kelimeBul())))

    def cumleSayiBul(self):
        print("Metindeki cumle sayisi: "+str(len(self.cumleBul())))

    def kelimeBul(self):
        return self.metin.rsplit(" ")

    def cumleBul(self):
        return self.metin.rsplit(". ")

    def sesliBul(self,harf):
        state=False
        if harf=='a' or harf=='A':
            state=True
        elif harf=='e' or harf=='E':
            state=True
        elif harf=='ı' or harf=='I':
            state=True
        elif harf=='o' or harf=='O':
            state=True
        elif harf=='u' or harf=='U':
            state=True
        elif harf=='i' or harf=='İ':
            state=True
        elif harf=='ö' or harf=='Ö':
            state=True
        elif harf=='ü' or harf=='Ü':
            state=True
        else:
            state=False
        return state

    def sesliHarfBul(self):
        count=0
        yeniMetin=self.metin.replace(" ","").replace(",","").replace(".","")
        for i in range(len(yeniMetin)):
            if self.sesliBul(yeniMetin[i]):
                count=count+1
        print("Sesli harf Sayisi: "+str(count))

    def buyukUnluUyumu(self):
        uyumuluCount=0
        uyumsuzCount=0
        kalin=['a','A','o','O','ı','I','u','U']
        ince=['e','E','ö','Ö','i','İ','ü','Ü']
        kelimeler=self.kelimeBul()
        for i in range(len(kelimeler)):
            kalinState=False
            inceState=False
            for j in range(len(kelimeler[i])):
                for k in range(len(kalin)):
                   if (kelimeler[i])[j]==kalin[k]:
                       kalinState=True
                       break

                for k in range(len(ince)):
                   if (kelimeler[i])[j]==ince[k]:
                       inceState=True
                       break
            
            if kalinState and inceState:
                uyumsuzCount=uyumsuzCount+1
            else:
                uyumuluCount=uyumuluCount+1
                
        print("Uyumlu Sayisi: "+str(uyumuluCount)+" Uyumsuz Sayisi: "+str(uyumsuzCount))

class sifrelemeYontemleri:
    metin=""
    def __init__(self,metin):
       self.metin=metin
    def sha256Sifreleme(self):
        crypter=hasher.sha256()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def sha224Sifreleme(self):
        crypter=hasher.sha224()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def sha1Sifreleme(self):
        crypter=hasher.sha1()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def sha384Sifreleme(self):
        crypter=hasher.sha384()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def sha512ifreleme(self):
        crypter=hasher.sha512()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def blake2bSifreleme(self):
        crypter=hasher.blake2b()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def blake2sSifreleme(self):
        crypter=hasher.blake2s()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    def md5Sifreleme(self):
        crypter=hasher.md5()
        crypter.update(self.metin.encode("utf-8"))
        hash=crypter.hexdigest()
        print(hash)
    
    def pad(self,s):
        return s + (32 - len(s) % 32) * chr(32 - len(s) % 32)	

    def unpad(self,s):
        return s[:-ord(s[len(s)-1:])]
    def key_generate(self,key):
        key = hasher.md5( hasher.sha256( (key).encode() ).hexdigest().encode() ).hexdigest().encode()
        return key
    def aesSifreleme(self,key):
        plain_text = base64.b64encode(self.metin.encode()).decode()
        backend = default_backend()
        cipher = Cipher(algorithms.AES(self.key_generate(key)), modes.CBC('4377777172699a75'.encode()), backend=backend)
        encryptor = cipher.encryptor()
        plain_text_byte = self.pad(plain_text).encode()
        buf = bytearray( 2*len(plain_text_byte) - 1  )
        len_encrypted = encryptor.update_into(plain_text_byte, buf)
        ct = bytes(buf[:len_encrypted]) + encryptor.finalize()	

        print(base64.b64encode(ct))

    def twofishSifreleme(self,key):
        print(len(self.metin.encode("utf-8")))
        try:
            T = Twofish(key.encode("utf8"))
            return T.encrypt(self.metin.encode("utf-8"))
        except:
            hata="Metin 16 karakterden oluşmalıdır! Mevcut: "+str(len(self.metin.encode("utf-8")))
            print (hata)

class Help:
    metin=""
    def __init__(self):
        self.metin="Bu modul Turkce yazim kurallarini kontrol eden ve sifreleme islemleri yapmaya yarayan bir python scriptidir. dilKontrol sinifi: 1) metinBelirle: sinif icerisinde kontrol yapilacak metin belirlenir. 2) kelimeSayiBul: metin icerisindeki kelime sayisini verir. 3) cumleSayiBul: metin icerisindeki cumle sayisini verir. 4) kelimeBul: metin icerisindeki kelimeleri ayirir. 5) cumleBul: metin icerisindeki cumleleri ayirir. 6) sesliBul: parametre olarak gonderilen harfin sesli olup olmadigini soyler. 7) sesliHarfBul: metin icersindeki sesli harf sayisini verir. 8) buyukUnluUyumu: metin icerisinde buyuk unlu uyumuna uyan ve uymayan kelimelerin sayisini verir. ------------------ sifrelemeYontemleri sinifi: 1) sha256Sifreleme: verilen metni sha256 algoritmasiyla sifreler. 2) sha224Sifreleme: verilen metni sha224 algoritmasiyla sifreler. 3) sha1Sifreleme: verilen metni sha1 algoritmasiyla sifreler. 4) sha384Sifreleme: verilen metni sha384 algoritmasiyla sifreler. 5) sha512Sifreleme: verilen metni sha512 algoritmasiyla sifreler. 6) blake2bSifreleme: verilen metni blake2b algoritmasiyla sifreler. 7) blake2sSifreleme: verilen metni blake2s algoritmasiyla sifreler. 8) aesSifreleme: verilen metni aes algoritmasiyla sifreler. 9) twofishSifreleme: verilen metni twofish algoritmasiyla sifreler."
    def yardim(self):
        print(self.metin)

if sys.argv[1]=="dilKontrol":
    tool =dilKontrol(sys.argv[3])
    if sys.argv[2]=="kelimeSayiBul":
        tool.kelimeSayiBul()
    elif sys.argv[2]=="cumleSayiBul":
        tool.cumleSayiBul()
    elif sys.argv[2]=="kelimeBul":
        tool.kelimeBul()
    elif sys.argv[2]=="cumleBul":
        tool.cumleBul()
    elif sys.argv[2]=="sesliHarfBul":
        tool.sesliHarfBul()
    elif sys.argv[2]=="buyukUnluUyumu":
        tool.buyukUnluUyumu()
elif sys.argv[1]=="sifrelemeYontemleri":
    tool =sifrelemeYontemleri(sys.argv[3])
    if sys.argv[2]=="sha256Sifreleme":
        tool.sha256Sifreleme()
    elif sys.argv[2]=="sha224Sifreleme":
        tool.sha224Sifreleme()
    elif sys.argv[2]=="sha1Sifreleme":
        tool.sha1Sifreleme()
    elif sys.argv[2]=="sha384Sifreleme":
        tool.sha384Sifreleme()
    elif sys.argv[2]=="sha512ifreleme":
        tool.sha512ifreleme()
    elif sys.argv[2]=="blake2bSifreleme":
        tool.blake2bSifreleme()
    elif sys.argv[2]=="md5Sifreleme":
        tool.md5Sifreleme()
    elif sys.argv[2]=="aesSifreleme":
        tool.aesSifreleme(sys.argv[4])
    elif sys.argv[2]=="twofishSifreleme":
        tool.twofishSifreleme(sys.argv[4])
elif sys.argv[1]=="Help":
    tool=Help()
    tool.yardim()