# TO DO:

- Create ToDictionary() and extra methods.
- Save responses as Json or txt files.
- Implement Tournaments endpoints.

# What is RiotNet?
RiotNet is an implementation of the Riot API in .NET written in C#. It's purpose is facilitate the usage of the API with asynchronous methods and many features that can be easily used. It also implements the DDragon (DataDragon) API to get certain data of the games, opening the posibilities of the application. Stop writting unnecesary code for many hours when RiotNet exists, with a few lines you can get anything that you want.

Currently RiotNet just supports GET request but in the future it will be able to execute POST request.

# Installation

Simply do:

```
git clone https://github.com/Zettte/RiotNet
```

# How to use RiotNet?

When you have already downloaded the package, go to your main program an paste the following code:

```cs
class Demo
{
    public static async Task Main(string[] args)
    {
        // It's important to setup all platforms at once, but you can change it later if your code needs it.
        
        RiotNetAPI Riot = new ("YOUR API KEY");

        // Change the region acording to your preferences.

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

And you'll get something like this.
- - -
![image](https://user-images.githubusercontent.com/93677342/193716925-be431a34-eca9-4e77-bf7d-c5e2b428d778.png)

- - - 
And don't wait to use out **DataDragon Implementation** to acces all the resources availables, like the Yasuo icon, and it gets better now, you can save it if you want!

```cs
    DDragon dataDragon = new DDragon();
    string champImgUrl = await dataDragon.GetChampionImage("Yasuo");

    await Media.Save(champImgUrl, "Yasuo.png");
```
