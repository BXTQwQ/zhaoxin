using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>This class is used to storage any kind of global value,
///  based on HashTable, so there should be no repeating tags, now has coded to prevented that.
/// 
/// </summary>
public static class MonoSingleton 
{
    static Hashtable list = new Hashtable();
    public static void Add<T>(string tag, T value)
    {
        if(list.ContainsKey(tag))
            throw new System.Exception("Current global value tag existed!");
        list.Add(tag, value);
    }
    /// <summary>The function returns the value instantly
    /// 
    /// </summary>
    /// <param name="tag">the tag of the value, cases are sensitive</param>
    /// <returns></returns>
    public static object Get(string tag)
    {
        return list[tag];
    }
    
    /// <summary> Ummm, It's just the same function like above but allows you to
    /// define certain type? Should I keep it?
    /// I'll add a obsolete mark to it. 
    /// </summary>
    /// <param name="tag">the tag of the value, cases are sensitive</param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    [ObsoleteAttribute]
    public static void Get<T>(string tag, out T value)
    {
        if(!list.ContainsKey(tag))
            throw new System.Exception("No tag found! Check your tag.");
        value = (T)list[tag];
    }
    /// <summary> Change the value inside the Singleton storage
    /// 
    /// </summary>
    /// <param name="tag">the tag of the value, cases are sensitive</param>
    /// <param name="changeValue">value that gives to the </param>
    /// <typeparam name="T"></typeparam>
    public static void Change<T>(string tag, T changeValue)
    {
        if(!list.ContainsKey(tag))
            throw new System.Exception("No tag found! Check your tag.");
        list[tag] = changeValue;
    }
}