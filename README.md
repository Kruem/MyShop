# Example Azurite Storage Local Azure

Azurite Setup
1. Install node.js

2. Install Azurite
- npm install azurite

Create Azurite Folder

1. Create Folder
- cd c:\
- mkdir azurite
- cd azurite

Local Certificate Setup

1. Install mkcert -> choco install mkcert

2. add RootCA -> mkcert -install

3. Create Certificate -> mkcert 127.0.0.1

run Azurite
-  azurite --oauth basic --cert 127.0.0.1.pem --key 127.0.0.1-key.pem

That will output the following

- Azurite Blob service is starting at https://127.0.0.1:10000
- Azurite Blob service is successfully listening at https://127.0.0.1:10000
- Azurite Queue service is starting at https://127.0.0.1:10001
- Azurite Queue service is successfully listening at https://127.0.0.1:10001

Azure CLI Setup 

1. Install the Azure CLI https://aka.ms/azcliget

Azure Storage Explorer

1. Install Azure Storage Explorer
https://azure.microsoft.com/en-us/features/storage-explorer/

Run Code in your folder Azurite
2 Import SSl Certificate
- mkcert -CAROOT

3. Certificate is located here C:\Users\YourUser\AppData\Local\mkcert

4. In Storage Exporer -> Select Edit-> SSL Certificates -> Import -> Select rootCA.pem

5. Add Azurite HTTPS Endpoint -> right-click on Local & Attached -> Storage Accounts and select Connect to Azure Storage

6.Attach to Local Emulator

-> protocol HTTPS -> Next and then click Connect
