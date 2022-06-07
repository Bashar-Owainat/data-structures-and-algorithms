using DataStructureApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class HashNode<T>
    {
        public HashNode<T> Next { get; set; }
        public string Key { get; set; }
        public T Value { get; set; }


    }

}

    public class MyHashtable<T>
{
    private readonly HashNode<T>[] buckets;

    public MyHashtable(int size)
    {
        buckets = new HashNode<T>[size];
    }

    public T Get(string key)
    {
        ValidateKey(key);

        var (_, node) = GetNodeByKey(key); // we used _ because we don't need a previous node and c# allow us to use _ instead
        if (node == null)
        {
            throw new ArgumentOutOfRangeException(nameof(key), "The key " + key + " is not found!");
        }
        return node.Value;
    }

    public void Set(string key, T item)
    {
        ValidateKey(key);

        var valueNode = new HashNode<T> { Key = key, Value = item, Next = null };
        int position = Hash(key);
        HashNode<T> listNode = buckets[position];

        if(null == listNode)
        {
            buckets[position] = valueNode;
        }
        else
        {
            while(null != listNode.Value)
            {
                listNode = listNode.Next;
            }
            listNode.Next = valueNode;
        }
    }
    public void ValidateKey(string key)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentNullException(nameof(key));
        }
    }

    protected (HashNode<T> previous, HashNode<T> current )GetNodeByKey(string key)
    {
        int position = Hash(key);
        HashNode<T> listNode = buckets[position];
        HashNode<T> previous = null;

        while(null != listNode)
        {
            if(listNode.Key == key)
            {
                return (previous, listNode);
            }
            previous = listNode;
            listNode = listNode.Next;
        }

        return (null, null);
    }

    public int Hash(string key)
    {
        return key[0] % buckets.Length;
    }
    public bool Contains(string key)
    {
        ValidateKey(key);

        var (_, node) = GetNodeByKey(key);
        return null != node; // if it contains then this expression will be ture
    }

    //public keys()
    //{

    //}

   

}