//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: steammessages_linkfilter.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterHashPrefixes_Request")]
  public partial class CCommunity_GetLinkFilterHashPrefixes_Request : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterHashPrefixes_Request() {}
    

    private uint? _hit_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint hit_type
    {
      get { return _hit_type?? default(uint); }
      set { _hit_type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool hit_typeSpecified
    {
      get { return _hit_type != null; }
      set { if (value == (_hit_type== null)) _hit_type = value ? this.hit_type : (uint?)null; }
    }
    private bool ShouldSerializehit_type() { return hit_typeSpecified; }
    private void Resethit_type() { hit_typeSpecified = false; }
    

    private uint? _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count?? default(uint); }
      set { _count = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool countSpecified
    {
      get { return _count != null; }
      set { if (value == (_count== null)) _count = value ? this.count : (uint?)null; }
    }
    private bool ShouldSerializecount() { return countSpecified; }
    private void Resetcount() { countSpecified = false; }
    

    private ulong? _start;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong start
    {
      get { return _start?? default(ulong); }
      set { _start = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool startSpecified
    {
      get { return _start != null; }
      set { if (value == (_start== null)) _start = value ? this.start : (ulong?)null; }
    }
    private bool ShouldSerializestart() { return startSpecified; }
    private void Resetstart() { startSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterHashPrefixes_Response")]
  public partial class CCommunity_GetLinkFilterHashPrefixes_Response : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterHashPrefixes_Response() {}
    
    private readonly global::System.Collections.Generic.List<uint> _hash_prefixes = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"hash_prefixes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> hash_prefixes
    {
      get { return _hash_prefixes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterHashes_Request")]
  public partial class CCommunity_GetLinkFilterHashes_Request : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterHashes_Request() {}
    

    private uint? _hit_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint hit_type
    {
      get { return _hit_type?? default(uint); }
      set { _hit_type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool hit_typeSpecified
    {
      get { return _hit_type != null; }
      set { if (value == (_hit_type== null)) _hit_type = value ? this.hit_type : (uint?)null; }
    }
    private bool ShouldSerializehit_type() { return hit_typeSpecified; }
    private void Resethit_type() { hit_typeSpecified = false; }
    

    private uint? _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count?? default(uint); }
      set { _count = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool countSpecified
    {
      get { return _count != null; }
      set { if (value == (_count== null)) _count = value ? this.count : (uint?)null; }
    }
    private bool ShouldSerializecount() { return countSpecified; }
    private void Resetcount() { countSpecified = false; }
    

    private ulong? _start;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong start
    {
      get { return _start?? default(ulong); }
      set { _start = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool startSpecified
    {
      get { return _start != null; }
      set { if (value == (_start== null)) _start = value ? this.start : (ulong?)null; }
    }
    private bool ShouldSerializestart() { return startSpecified; }
    private void Resetstart() { startSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterHashes_Response")]
  public partial class CCommunity_GetLinkFilterHashes_Response : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterHashes_Response() {}
    
    private readonly global::System.Collections.Generic.List<byte[]> _hashes = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(1, Name=@"hashes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> hashes
    {
      get { return _hashes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterListVersion_Request")]
  public partial class CCommunity_GetLinkFilterListVersion_Request : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterListVersion_Request() {}
    

    private uint? _hit_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint hit_type
    {
      get { return _hit_type?? default(uint); }
      set { _hit_type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool hit_typeSpecified
    {
      get { return _hit_type != null; }
      set { if (value == (_hit_type== null)) _hit_type = value ? this.hit_type : (uint?)null; }
    }
    private bool ShouldSerializehit_type() { return hit_typeSpecified; }
    private void Resethit_type() { hit_typeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCommunity_GetLinkFilterListVersion_Response")]
  public partial class CCommunity_GetLinkFilterListVersion_Response : global::ProtoBuf.IExtensible
  {
    public CCommunity_GetLinkFilterListVersion_Response() {}
    

    private string _version;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string version
    {
      get { return _version?? ""; }
      set { _version = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool versionSpecified
    {
      get { return _version != null; }
      set { if (value == (_version== null)) _version = value ? this.version : (string)null; }
    }
    private bool ShouldSerializeversion() { return versionSpecified; }
    private void Resetversion() { versionSpecified = false; }
    

    private ulong? _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong count
    {
      get { return _count?? default(ulong); }
      set { _count = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool countSpecified
    {
      get { return _count != null; }
      set { if (value == (_count== null)) _count = value ? this.count : (ulong?)null; }
    }
    private bool ShouldSerializecount() { return countSpecified; }
    private void Resetcount() { countSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ICommunityLinkFilter
    {
      CCommunity_GetLinkFilterHashPrefixes_Response GetLinkFilterHashPrefixes(CCommunity_GetLinkFilterHashPrefixes_Request request);
    CCommunity_GetLinkFilterHashes_Response GetLinkFilterHashes(CCommunity_GetLinkFilterHashes_Request request);
    CCommunity_GetLinkFilterListVersion_Response GetLinkFilterListVersion(CCommunity_GetLinkFilterListVersion_Request request);
    
    }
    
    
}
#pragma warning restore 1591