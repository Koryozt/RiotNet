# TO DO:

- Implement GameClient API
- Implement docs endpoints for LoR, TFT and Valorant.
- Implement Tournaments endpoints.

# What is RiotNet?
RiotNet is an implementation of the Riot API in .NET written in C#. It's purpose is facilitate the usage of the API with asynchronous methods and many features that can be easily used. It also implements the DDragon (DataDragon) API to get certain data of the games, opening the posibilities of the application. Stop writting unnecesary code for many hours when RiotNet exists, with a few lines you can get anything that you want.

Currently RiotNet just supports GET request but in the future it will be able to execute POST request.

# Installation

Simply do:

```
git clone https://github.com/Zettte/RiotNet
```

Or download the Source Code from the releases: https://github.com/Zettte/RiotNet/releases/tag/v1.1.0

# How to use RiotNet?

When you have already downloaded the package, go to your main program an paste the following code:

```cs
class Demo
{
    public static async Task Main(string[] args)
    {
        RiotNetAPI Riot = new ("YOUR API KEY");

        // Change the region acording to your preferences. You can see the default platforms and regions in the RiotNetAPI.cs file.

        RiotNetAPI.LolPlatform = LeaguePlatforms.LA1;
    }
}
```

This will setup everything and you can use every method inside the RiotNetAPI class, for example, let's say you want to get your account using your LoL summoner name, there's no problem, just do this:

```cs
    // Send me a friend request. ^^
    var summonerData = Riot.LeagueofLegends.GetSummonerByAccountName("Zette");
    Console.WriteLine(summonerData);
```

And you'll get something like this:

```json
Executing request to: https://la1.api.riotgames.com/lol/summoner/v4/summoners/by-name/Zette/
{
    "id": "Summoner ID",
    "accountId": "Account ID",
    "puuid": "Summoner PUUID",
    "name": "Zette",
    "profileIconId": 16,
    "revisionDate": "revision Date",
    "summonerLevel": 152
}
```
And don't wait to use our **DataDragon Implementation** to acces all the resources availables, like all the Yasuo assets available. And it gets better now, you can save it on your computer!

```cs
    string champImageUrl = await Riot.DataDragon.GetChampionSplahSAsset("Yasuo");
    await ContentHandler.SaveAsImage(champImageUrl, "Yasuo.jpg");
    // And now you have a nice wallpaper.
```
Wanting information about something related to another Riot's product? Say no more, we got you.

```cs
    var leaderboard = await API.LegendsOfRunaterra.GetLeaderboard();
    var league = await API.TeamfightTactics.GetLeague(AdvancedQueues.challengerleagues);
    var match = await API.Valorant.GetMatch("Any match ID");
```

What are you waiting to use RiotNet and create incredible things? The project is currently in progress and it's being updated almost daily, but don't wait anymore and start using RiotNet.

