//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DesignTemplate.proto
namespace KData
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DesignTemplateRoleInfoConfig")]
  public partial class DesignTemplateRoleInfoConfig : global::ProtoBuf.IExtensible
  {
    public DesignTemplateRoleInfoConfig() {}
    

    private int _role_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }

    private string _role_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"role_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string role_name
    {
      get { return _role_name; }
      set { _role_name = value; }
    }

    private int _role_type = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"role_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int role_type
    {
      get { return _role_type; }
      set { _role_type = value; }
    }

    private string _role_story = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"role_story", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string role_story
    {
      get { return _role_story; }
      set { _role_story = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _init_item = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"init_item", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> init_item
    {
      get { return _init_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}