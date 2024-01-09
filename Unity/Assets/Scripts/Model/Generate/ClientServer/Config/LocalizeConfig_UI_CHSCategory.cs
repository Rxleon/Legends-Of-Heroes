//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System;

namespace ET
{
   
[Config]
public partial class LocalizeConfig_UI_CHSCategory: ConfigSingleton<LocalizeConfig_UI_CHSCategory>
{
    private readonly Dictionary<string, LocalizeConfig_CHS> _dataMap;
    private readonly List<LocalizeConfig_CHS> _dataList;
    
    public LocalizeConfig_UI_CHSCategory(ByteBuf _buf)
    {
        _dataMap = new Dictionary<string, LocalizeConfig_CHS>();
        _dataList = new List<LocalizeConfig_CHS>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            LocalizeConfig_CHS _v;
            _v = LocalizeConfig_CHS.DeserializeLocalizeConfig_CHS(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Key, _v);
        }
        PostInit();
    }
    
    public bool Contain(string id)
    {
        return _dataMap.ContainsKey(id);
    }

    public Dictionary<string, LocalizeConfig_CHS> GetAll()
    {
        return _dataMap;
    }
    
    public List<LocalizeConfig_CHS> DataList => _dataList;

    public LocalizeConfig_CHS GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public LocalizeConfig_CHS Get(string key) => _dataMap[key];
    public LocalizeConfig_CHS this[string key] => _dataMap[key];

    public override void Resolve(ConcurrentDictionary<Type, IConfigSingleton> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    public override void TrimExcess()
    {
        _dataMap.TrimExcess();
        _dataList.TrimExcess();
    }
    
    
    public override string ConfigName()
    {
        return typeof(LocalizeConfig_CHS).Name;
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}