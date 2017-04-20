﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///unity中用到大量重复的物体，例如发射的子弹，可以引入对象池来管理，优化内存。
///对象池使用的基本思路是：
///将用过的对象保存起来，等下一次需要这种对象的时候，再拿出来重复使用。恰当地使用对象池，可以在一定程度上减少频繁创建对象所造成的开销。
///并非所有对象都适合拿来池化――因为维护对象池也要造成一定开销。对生成时开销不大的对象进行池化，反而可能会出现“维护对象池的开销”大于“生成新对象的开销”，从而使性能降低的情况。
/// </summary>
public class GameObjectPool : MonoBehaviour
{

    private GameObjectPool _instance;

    public GameObjectPool GetInstance()
    {
        return _instance;
    }

    private static Dictionary<string,List<Object>> pool = new Dictionary<string, List<Object>>();

    public void Awake()
    {
        _instance = this;
    }

    public static Object Get(string prefabName, Vector3 position, Quaternion ratation)
    {
        //拼接制作dic的key名，因为instantiate出的gameobject都会自动命名为gameobject(Clone),这里是为了通下面store方法里给key的命名匹配
        string key = prefabName + "(Clone)";
    }
}
