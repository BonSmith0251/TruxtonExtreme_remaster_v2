namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000018")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MultipleSubstitutionRecord
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("targetGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000099")]
	private uint m_TargetGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("substituteGlyphIDs")]
	[SerializeField]
	[Token(Token = "0x400009A")]
	private UInt32[] m_SubstituteGlyphIDs; //Field offset: 0x8

}

