# SecureAppSettingsDotNetCoreSample
A sample app demonstrates storing and retrieving sensitive app settings from an Azure Key Vault. 
To try out the app, you need a valid Azure subscription which has permission to create an Azure Key Vault. 
Below is the recap of the steps. For more details and insights, check out the [blog post](https://www.taithienbo.com/secure-app-settings-in-net-core-2/). 
## Set up: 
1. Register the app in Azure Active Directory. 
1. Generate the key (app secret). Take note of the app id and secret.
1. Create an Azure Key Vault. Note the DNS Name of the vault under Overview. 
1. Add the secret. Set Name = "My Secret Key", Value = "Insert your secret value here". 
1. Grant the app Get and List permissions to the vault using Access Control. 
1. Add the app id and secret to the environment variables. You may need to restart your machine for the changes to take effect. 
   For MacOS, setting the environment variables is a bit tricky. I learned from this [post](https://placona.co.uk/) which references this [SO thread](https://stackoverflow.com/questions/35643759/c-sharp-environment-getenvironmentvariable-not-working-on-osx/35644532)
     > OS-X GUI apps will not inherit your private/custom env vars that are defined via a shell (bash, zsh, etc...) if they are 
     > launched from Finder/Spotlight.
     
     Essentially, all you need is adding these lines in your .bash_profile. The last line is for Visual Studio to read the environments when we launch it from Finder/Spotlight
```bash
export SECURE_APP_Vault__ClientId="Insert the Application Id in step 2."
export SECURE_APP_Vault__ClientSecret="Insert the key generated in step 2."
alias vs='/Applications/Visual\ Studio.app/Contents/MacOS/VisualStudio &'

```
  
For Windows, you can just add the SECURE_APP_Vault__ClientId and SECURE_APP_Vault__ClientSecret under the user environment 
variables.

Run the app. If everything is set up correctly, the app should returns a json object showing the secret value you set in the 
vault. 
