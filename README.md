# chatbotWeb

{
  "$schema": "https://developer.microsoft.com/json-schemas/teams/v1.5/MicrosoftTeams.schema.json",
  "manifestVersion": "1.5",
  "version": "1.0.1",
  "id": "0000----",
  "packageName": "com.example.demobot",
  "developer": {
    "name": "Echo Bot NEXCOシステムズ",
    "websiteUrl": "https://website.com/",
    "privacyUrl": "https://website.com/privacy",
    "termsOfUseUrl": "https://website.com/app-tos"
  },
  "name": {
    "short": "EchoBot"
  },
  "description": {
    "short": "Echo Bot",
    "full": "Echo Bot -Version 1.1"
  },
  "icons": {
    "outline": "32x32.png",
    "color": "192x192.png"
  },
  "accentColor": "#AA3333",
  "bots": [
    {
      "botId": "0000",
      "scopes": [ "team", "personal", "groupchat" ],
      "commandLists": [
        {
          "scopes": [ "team", "personal", "groupchat" ],
          "commands": [
            {
              "title": "12:00に群馬県で震度５強の地震を観測",
              "description": "help"
            }
          ]
        }
      ],
      "supportsFiles": true
    }
  ],
  "validDomains": [
    "*.azurewebsites.net"
  ]
}
