
using System.Text;

public class WarframeWorldStateData
{
    public int Version { get; set; }
    public string MobileVersion { get; set; }
    public string BuildLabel { get; set; }
    public int Time { get; set; }
    public int Date { get; set; }
    public Event[] Events { get; set; }
    public Goalclass[] Goals { get; set; }
    public Alert[] Alerts { get; set; }
    public Sorty[] Sorties { get; set; }
    public Syndicatemission[] SyndicateMissions { get; set; }
    public Activemission[] ActiveMissions { get; set; }
    public object[] GlobalUpgrades { get; set; }
    public Flashsale[] FlashSales { get; set; }
    public Invasion[] Invasions { get; set; }
    public object[] HubEvents { get; set; }
    public Nodeoverride[] NodeOverrides { get; set; }
    public Badlandnode[] BadlandNodes { get; set; }
    public Voidtrader[] VoidTraders { get; set; }
    public Primeaccessavailability PrimeAccessAvailability { get; set; }
    public Primevaultavailability[] PrimeVaultAvailabilities { get; set; }
    public Dailydeal[] DailyDeals { get; set; }
    public Libraryinfo LibraryInfo { get; set; }
    public Pvpchallengeinstance[] PVPChallengeInstances { get; set; }
    public object[] PersistentEnemies { get; set; }
    public object[] PVPAlternativeModes { get; set; }
    public object[] PVPActiveTournaments { get; set; }
    public float[] ProjectPct { get; set; }
    public string WorldSeed { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Version: " + Version + "\n");
        result.Append("MobileVersion: " + MobileVersion + "\n");
        result.Append("BuildLabel: " + BuildLabel + "\n");
        result.Append("Time: " + Time + "\n");
        result.Append("Date: " + Date + "\n");

        result.Append(Events.ToString());
        result.Append(Goals.ToString());
        result.Append(Alerts.ToString());
        result.Append(Sorties.ToString());
        result.Append(SyndicateMissions.ToString());
        result.Append(ActiveMissions.ToString());
        result.Append(GlobalUpgrades.ToString());
        result.Append(FlashSales.ToString());
        result.Append(Invasions.ToString());
        result.Append(NodeOverrides.ToString());
        result.Append(BadlandNodes.ToString());
        result.Append(VoidTraders.ToString());
        result.Append(PrimeAccessAvailability.ToString());
        result.Append(PrimeVaultAvailabilities.ToString());
        result.Append(DailyDeals.ToString());
        result.Append(LibraryInfo.ToString());
        result.Append(PVPChallengeInstances.ToString());
        result.Append(WorldSeed.ToString());

        return result.ToString();
    }
}

public class Primeaccessavailability
{
    public string State { get; set; }
}

public class Libraryinfo
{
    public string LastCompletedTargetType { get; set; }
}

public class Event
{
    public _Id _id { get; set; }
    public Messageclass[] Messages { get; set; }
    public string Prop { get; set; }
    public Date Date { get; set; }
    public bool Priority { get; set; }
    public bool MobileOnly { get; set; }
    public string ImageUrl { get; set; }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Event { ");
        result.Append("     " + "Messages { ");
        foreach(Messageclass message in Messages)
        {
            result.Append("     " + "     " + message.ToString());
        }
        result.Append("     " + "}");
        result.Append("     " + "Prop: " + Prop);
        result.Append("     " + "Date: " + Date);
        result.Append("     " + "Priority: " + Priority);
        result.Append("     " + "MobileOnly: " + MobileOnly);
        result.Append("     " + "ImageUrl: " + ImageUrl);
        result.Append("}");

        return result.ToString();
    }
}

public class _Id
{
    public string oid { get; set; }
}

public class Date
{
    public Date date { get; set; }
}

//public class Date
//{
//    public string numberLong { get; set; }
//}

public class Messageclass
{
    public string LanguageCode { get; set; }
    public string Message { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Language Code: " + LanguageCode);
        result.Append("Message: " + Message);

        return result.ToString();
    }
}

public class Goalclass
{
    public _Id1 _id { get; set; }
    public Activation Activation { get; set; }
    public Expiry Expiry { get; set; }
    public Altactivation AltActivation { get; set; }
    public int Count { get; set; }
    public int Goal { get; set; }
    public int GoalInterim { get; set; }
    public int GoalInterim2 { get; set; }
    public int Success { get; set; }
    public bool Personal { get; set; }
    public string ScoreVar { get; set; }
    public string ScoreMaxTag { get; set; }
    public string ScoreMaxNode { get; set; }
    public bool ClampNodeScores { get; set; }
    public string Node { get; set; }
    public string[] ConcurrentMissionKeyNames { get; set; }
    public int[] ConcurrentNodeReqs { get; set; }
    public string[] ConcurrentNodes { get; set; }
    public string MissionKeyName { get; set; }
    public string Faction { get; set; }
    public string Desc { get; set; }
    public string Icon { get; set; }
    public string Tag { get; set; }
    public Rewardinterim RewardInterim { get; set; }
    public Rewardinterim2 RewardInterim2 { get; set; }
    public Reward Reward { get; set; }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Goal { ");
        //result.Append("     " + "Messages { ");
        //foreach (Messageclass message in Messages)
        //{
        //    result.Append("     " + "     " + message.ToString());
        //}
        //result.Append("     " + "}");
        //result.Append("     " + "Prop: " + Prop);
        //result.Append("     " + "Date: " + Date);
        //result.Append("     " + "Priority: " + Priority);
        //result.Append("     " + "MobileOnly: " + MobileOnly);
        //result.Append("     " + "ImageUrl: " + ImageUrl);
        //result.Append("}");

        return result.ToString();
    }
}

public class _Id1
{
    public string oid { get; set; }
}

public class Activation
{
    public Date1 date { get; set; }
}

public class Date1
{
    public string numberLong { get; set; }
}

public class Expiry
{
    public Date2 date { get; set; }
}

public class Date2
{
    public string numberLong { get; set; }
}

public class Altactivation
{
    public Date3 date { get; set; }
}

public class Date3
{
    public string numberLong { get; set; }
}

public class Rewardinterim
{
    public string[] items { get; set; }
}

public class Rewardinterim2
{
    public string[] items { get; set; }
}

public class Reward
{
    public string[] items { get; set; }
}

public class Alert
{
    public _Id2 _id { get; set; }
    public Activation1 Activation { get; set; }
    public Expiry1 Expiry { get; set; }
    public Missioninfo MissionInfo { get; set; }
}

public class _Id2
{
    public string oid { get; set; }
}

public class Activation1
{
    public Date4 date { get; set; }
}

public class Date4
{
    public string numberLong { get; set; }
}

public class Expiry1
{
    public Date5 date { get; set; }
}

public class Date5
{
    public string numberLong { get; set; }
}

public class Missioninfo
{
    public string missionType { get; set; }
    public string faction { get; set; }
    public string location { get; set; }
    public string levelOverride { get; set; }
    public string enemySpec { get; set; }
    public int minEnemyLevel { get; set; }
    public int maxEnemyLevel { get; set; }
    public float difficulty { get; set; }
    public int seed { get; set; }
    public bool archwingRequired { get; set; }
    public Missionreward missionReward { get; set; }
    public string extraEnemySpec { get; set; }
    public int maxWaveNum { get; set; }
}

public class Missionreward
{
    public int credits { get; set; }
    public Counteditem[] countedItems { get; set; }
    public string[] items { get; set; }
}

public class Counteditem
{
    public string ItemType { get; set; }
    public int ItemCount { get; set; }
}

public class Sorty
{
    public _Id3 _id { get; set; }
    public Activation2 Activation { get; set; }
    public Expiry2 Expiry { get; set; }
    public string Boss { get; set; }
    public string Reward { get; set; }
    public object[] ExtraDrops { get; set; }
    public int Seed { get; set; }
    public Variant[] Variants { get; set; }
    public bool Twitter { get; set; }
}

public class _Id3
{
    public string oid { get; set; }
}

public class Activation2
{
    public Date6 date { get; set; }
}

public class Date6
{
    public string numberLong { get; set; }
}

public class Expiry2
{
    public Date7 date { get; set; }
}

public class Date7
{
    public string numberLong { get; set; }
}

public class Variant
{
    public string missionType { get; set; }
    public string modifierType { get; set; }
    public string node { get; set; }
    public string tileset { get; set; }
}

public class Syndicatemission
{
    public _Id4 _id { get; set; }
    public Activation3 Activation { get; set; }
    public Expiry3 Expiry { get; set; }
    public string Tag { get; set; }
    public int Seed { get; set; }
    public string[] Nodes { get; set; }
}

public class _Id4
{
    public string oid { get; set; }
}

public class Activation3
{
    public Date8 date { get; set; }
}

public class Date8
{
    public string numberLong { get; set; }
}

public class Expiry3
{
    public Date9 date { get; set; }
}

public class Date9
{
    public string numberLong { get; set; }
}

public class Activemission
{
    public _Id5 _id { get; set; }
    public int Region { get; set; }
    public int Seed { get; set; }
    public Activation4 Activation { get; set; }
    public Expiry4 Expiry { get; set; }
    public string Node { get; set; }
    public string Modifier { get; set; }
}

public class _Id5
{
    public string oid { get; set; }
}

public class Activation4
{
    public Date10 date { get; set; }
}

public class Date10
{
    public string numberLong { get; set; }
}

public class Expiry4
{
    public Date11 date { get; set; }
}

public class Date11
{
    public string numberLong { get; set; }
}

public class Flashsale
{
    public string TypeName { get; set; }
    public Startdate StartDate { get; set; }
    public Enddate EndDate { get; set; }
    public bool Featured { get; set; }
    public bool Popular { get; set; }
    public int BannerIndex { get; set; }
    public int Discount { get; set; }
    public int RegularOverride { get; set; }
    public int PremiumOverride { get; set; }
    public int BogoBuy { get; set; }
    public int BogoGet { get; set; }
}

public class Startdate
{
    public Date12 date { get; set; }
}

public class Date12
{
    public string numberLong { get; set; }
}

public class Enddate
{
    public Date13 date { get; set; }
}

public class Date13
{
    public string numberLong { get; set; }
}

public class Invasion
{
    public _Id6 _id { get; set; }
    public string Faction { get; set; }
    public string Node { get; set; }
    public int Count { get; set; }
    public int Goal { get; set; }
    public string LocTag { get; set; }
    public bool Completed { get; set; }
    public object AttackerReward { get; set; }
    public Attackermissioninfo AttackerMissionInfo { get; set; }
    public Defenderreward DefenderReward { get; set; }
    public Defendermissioninfo DefenderMissionInfo { get; set; }
    public Activation5 Activation { get; set; }
}

public class _Id6
{
    public string oid { get; set; }
}

public class Attackermissioninfo
{
    public int seed { get; set; }
    public string faction { get; set; }
}

public class Defenderreward
{
    public Counteditem1[] countedItems { get; set; }
}

public class Counteditem1
{
    public string ItemType { get; set; }
    public int ItemCount { get; set; }
}

public class Defendermissioninfo
{
    public int seed { get; set; }
    public string faction { get; set; }
    public object[] missionReward { get; set; }
}

public class Activation5
{
    public Date14 date { get; set; }
}

public class Date14
{
    public string numberLong { get; set; }
}

public class Nodeoverride
{
    public _Id7 _id { get; set; }
    public string Node { get; set; }
    public bool Hide { get; set; }
    public string Faction { get; set; }
    public string EnemySpec { get; set; }
    public string ExtraEnemySpec { get; set; }
    public Expiry5 Expiry { get; set; }
}

public class _Id7
{
    public string oid { get; set; }
}

public class Expiry5
{
    public Date15 date { get; set; }
}

public class Date15
{
    public string numberLong { get; set; }
}

public class Badlandnode
{
    public _Id8 _id { get; set; }
    public Defenderinfo DefenderInfo { get; set; }
    public History[] History { get; set; }
    public string Node { get; set; }
    public Postconflictcooldown PostConflictCooldown { get; set; }
}

public class _Id8
{
    public string oid { get; set; }
}

public class Defenderinfo
{
    public int CreditsTaxRate { get; set; }
    public int MemberCreditsTaxRate { get; set; }
    public int ItemsTaxRate { get; set; }
    public int MemberItemsTaxRate { get; set; }
    public Taxchangeallowedtime TaxChangeAllowedTime { get; set; }
    public bool IsAlliance { get; set; }
    public Id Id { get; set; }
    public string Name { get; set; }
    public int StrengthRemaining { get; set; }
    public int MaxStrength { get; set; }
    public Deploymentactivationtime DeploymentActivationTime { get; set; }
    public string RailType { get; set; }
    public string MOTD { get; set; }
    public string DeployerName { get; set; }
    public string DeployerClan { get; set; }
    public int RailHealReserve { get; set; }
    public float HealRate { get; set; }
    public int DamagePerMission { get; set; }
    public int BattlePayReserve { get; set; }
    public int MissionBattlePay { get; set; }
    public string BattlePaySetBy { get; set; }
    public string BattlePaySetByClan { get; set; }
    public string TaxLastChangedBy { get; set; }
    public string TaxLastChangedByClan { get; set; }
    public Railid RailId { get; set; }
}

public class Taxchangeallowedtime
{
    public Date16 date { get; set; }
}

public class Date16
{
    public string numberLong { get; set; }
}

public class Id
{
    public string oid { get; set; }
}

public class Deploymentactivationtime
{
    public Date17 date { get; set; }
}

public class Date17
{
    public string numberLong { get; set; }
}

public class Railid
{
    public string oid { get; set; }
}

public class Postconflictcooldown
{
    public Date18 date { get; set; }
}

public class Date18
{
    public string numberLong { get; set; }
}

public class History
{
    public string Def { get; set; }
    public Defid DefId { get; set; }
    public bool DefAli { get; set; }
    public string Att { get; set; }
    public Attid AttId { get; set; }
    public bool AttAli { get; set; }
    public Winid WinId { get; set; }
    public Start Start { get; set; }
    public End End { get; set; }
}

public class Defid
{
    public string oid { get; set; }
}

public class Attid
{
    public string oid { get; set; }
}

public class Winid
{
    public string oid { get; set; }
}

public class Start
{
    public Date19 date { get; set; }
}

public class Date19
{
    public string numberLong { get; set; }
}

public class End
{
    public Date20 date { get; set; }
}

public class Date20
{
    public string numberLong { get; set; }
}

public class Voidtrader
{
    public _Id9 _id { get; set; }
    public Activation6 Activation { get; set; }
    public Expiry6 Expiry { get; set; }
    public string Character { get; set; }
    public string Node { get; set; }
}

public class _Id9
{
    public string oid { get; set; }
}

public class Activation6
{
    public Date21 date { get; set; }
}

public class Date21
{
    public string numberLong { get; set; }
}

public class Expiry6
{
    public Date22 date { get; set; }
}

public class Date22
{
    public string numberLong { get; set; }
}

public class Primevaultavailability
{
    public string State { get; set; }
}

public class Dailydeal
{
    public string StoreItem { get; set; }
    public Activation7 Activation { get; set; }
    public Expiry7 Expiry { get; set; }
    public int Discount { get; set; }
    public int OriginalPrice { get; set; }
    public int SalePrice { get; set; }
    public int AmountTotal { get; set; }
    public int AmountSold { get; set; }
}

public class Activation7
{
    public Date23 date { get; set; }
}

public class Date23
{
    public string numberLong { get; set; }
}

public class Expiry7
{
    public Date24 date { get; set; }
}

public class Date24
{
    public string numberLong { get; set; }
}

public class Pvpchallengeinstance
{
    public _Id10 _id { get; set; }
    public string challengeTypeRefID { get; set; }
    public Startdate1 startDate { get; set; }
    public Enddate1 endDate { get; set; }
    public Param[] _params { get; set; }
    public bool isGenerated { get; set; }
    public string PVPMode { get; set; }
    public Subchallenge[] subChallenges { get; set; }
    public string Category { get; set; }
}

public class _Id10
{
    public string oid { get; set; }
}

public class Startdate1
{
    public Date25 date { get; set; }
}

public class Date25
{
    public string numberLong { get; set; }
}

public class Enddate1
{
    public Date26 date { get; set; }
}

public class Date26
{
    public string numberLong { get; set; }
}

public class Param
{
    public string n { get; set; }
    public int v { get; set; }
}

public class Subchallenge
{
    public string oid { get; set; }
}
