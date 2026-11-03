namespace UnityEngine.UIElements;

[Token(Token = "0x20003FD")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D69")]
	public List<TimeValue> transitionDelay; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D6A")]
	public List<TimeValue> transitionDuration; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D6B")]
	public List<StylePropertyName> transitionProperty; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D6C")]
	public List<EasingFunction> transitionTimingFunction; //Field offset: 0x18

	[Address(RVA = "0x327F5C0", Offset = "0x327E9C0", Length = "0x18C")]
	[Token(Token = "0x6001E4D")]
	public override TransitionData Copy() { }

	[Address(RVA = "0x327F450", Offset = "0x327E850", Length = "0x16E")]
	[Token(Token = "0x6001E4E")]
	public override void CopyFrom(ref TransitionData other) { }

	[Address(RVA = "0x327F750", Offset = "0x327EB50", Length = "0x3A")]
	[Token(Token = "0x6001E50")]
	public override bool Equals(TransitionData other) { }

	[Address(RVA = "0x327F790", Offset = "0x327EB90", Length = "0xB6")]
	[Token(Token = "0x6001E51")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x327F850", Offset = "0x327EC50", Length = "0xBB")]
	[Token(Token = "0x6001E52")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327F910", Offset = "0x327ED10", Length = "0x45")]
	[Token(Token = "0x6001E4F")]
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

}

