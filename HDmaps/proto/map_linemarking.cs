// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_linemarking.proto

#pragma warning disable 1591, 0612, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LinemarkingType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LinemarkingType()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Type.Unknown)]
        public Type types
        {
            get { return __pbn__types ?? Type.Unknown; }
            set { __pbn__types = value; }
        }
        public bool ShouldSerializetypes()
        {
            return __pbn__types != null;
        }
        public void Resettypes()
        {
            __pbn__types = null;
        }
        private Type? __pbn__types;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"DOTTED_YELLOW")]
            DottedYellow = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"DOTTED_WHITE")]
            DottedWhite = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"SOLID_YELLOW")]
            SolidYellow = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"SOLID_WHITE")]
            SolidWhite = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"DOUBLE_YELLOW")]
            DoubleYellow = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"CURB")]
            Curb = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"STOP_LINE")]
            StopLine = 7,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Linemarking : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Linemarking()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Curve lanemarking_curve { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public LinemarkingType type { get; set; }

    }

}

#pragma warning restore 1591, 0612, 3021
