using System.Collections.Generic;
public class Charastat 
{

    public Charastat()
    {
        map.Add(eChar.health,health);
        map.Add(eChar.recovery, recovery);
        map.Add(eChar.defence, defence);
        map.Add(eChar.speed, speed);
        map.Add(eChar.atk, atk);
        map.Add(eChar.pelletSpeed, pelletSpeed);
        map.Add(eChar.pelletExistTime, pelletExistTime);
        map.Add(eChar.atkRange, atkRange);
        map.Add(eChar.atkFreq, atkFreq);
        map.Add(eChar.pelletAmount, pelletAmount);
        map.Add(eChar.respawnChance, respawnChance);
        map.Add(eChar.pickupRange, pickupRange);
        map.Add(eChar.luck, luck);
        map.Add(eChar.expGainRatio, expGainRatio);
        map.Add(eChar.coinGainRatio, coinGainRatio);
        map.Add(eChar.curse, curse);
    }

#region Parameter
    public float health;//Health
    public float recovery;//Health regeneration
    public float defence;//Defence
    public float speed;//Movement speed;
    public float speedMultiplier;
    public float atk;//Attack Strength
    public float pelletSpeed;//Pellet movement speed;
    public float pelletExistTime;//How long can a pellet exist
    public float atkRange;//How large is a pellet
    public float atkFreq;//How fast to shoot the next pellet
    public float pelletAmount;//How many extra pellets will be fire.
    public float respawnChance;//Chances to respawn
    public float pickupRange;//The distance that player can pick up item automatically.
    public float luck;//How lucky is the player.
    public float expGainRatio;//Extra exps gain.
    public float coinGainRatio;//Extra coins gain.
    public float curse;//It's about enhancing the enemy.
    
#endregion

#region Enumerator
    public enum eChar
    {
        health,recovery,defence,speed,atk,pelletSpeed,pelletExistTime,
        atkRange,atkFreq,pelletAmount,respawnChance,pickupRange,luck,
        expGainRatio,coinGainRatio,curse
    }

    Dictionary<eChar, float> map = new Dictionary<eChar, float>();
#endregion

#region PublicFunction

    /// <summary> Change Single stat
    /// </summary>
    /// <param name="type"></param>
    /// <param name="value"></param>
    public void changeStat(eChar type, float value)
    {
        map[type] = value;
    }

    /// <summary> Get Single Stat
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public float getStat(eChar type)
    {
        return map[type];
    }
#endregion
}
