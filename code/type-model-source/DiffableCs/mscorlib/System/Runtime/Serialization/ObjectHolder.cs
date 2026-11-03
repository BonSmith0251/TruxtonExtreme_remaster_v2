namespace System.Runtime.Serialization;

[Token(Token = "0x20003EA")]
internal sealed class ObjectHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F4F")]
	private object m_object; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F50")]
	internal long m_id; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F51")]
	private int m_missingElementsRemaining; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F52")]
	private int m_missingDecendents; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F53")]
	internal SerializationInfo m_serInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F54")]
	internal ISerializationSurrogate m_surrogate; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F55")]
	internal FixupHolderList m_missingElements; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F56")]
	internal LongList m_dependentObjects; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F57")]
	internal ObjectHolder m_next; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F58")]
	internal int m_flags; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000F59")]
	private bool m_markForFixupWhenAvailable; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F5A")]
	private ValueTypeFixupInfo m_valueFixup; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F5B")]
	private TypeLoadExceptionHolder m_typeLoad; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F5C")]
	private bool m_reachable; //Field offset: 0x68

	[Token(Token = "0x170003B5")]
	internal bool CanObjectValueChange
	{
		[Address(RVA = "0x1F0D230", Offset = "0x1F0C630", Length = "0x19")]
		[Token(Token = "0x6001E12")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x170003B4")]
	internal bool CanSurrogatedObjectValueChange
	{
		[Address(RVA = "0x1F0D250", Offset = "0x1F0C650", Length = "0x85")]
		[Token(Token = "0x6001E11")]
		internal get { } //Length: 133
	}

	[Token(Token = "0x170003C1")]
	internal bool CompletelyFixed
	{
		[Address(RVA = "0x1F0D2E0", Offset = "0x1F0C6E0", Length = "0x1E")]
		[Token(Token = "0x6001E24")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x170003C2")]
	internal long ContainerID
	{
		[Address(RVA = "0x1F0D300", Offset = "0x1F0C700", Length = "0x13")]
		[Token(Token = "0x6001E25")]
		internal get { } //Length: 19
	}

	[Token(Token = "0x170003BE")]
	internal LongList DependentObjects
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001E1F")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6001E20")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003B6")]
	internal int DirectlyDependentObjects
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6001E13")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170003B2")]
	internal bool HasISerializable
	{
		[Address(RVA = "0x1F0D320", Offset = "0x1F0C720", Length = "0x8")]
		[Token(Token = "0x6001E0F")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003B3")]
	internal bool HasSurrogate
	{
		[Address(RVA = "0x1F0D330", Offset = "0x1F0C730", Length = "0x8")]
		[Token(Token = "0x6001E10")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003AE")]
	internal bool IsIncompleteObjectReference
	{
		[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
		[Token(Token = "0x6001E09")]
		internal get { } //Length: 7
		[Address(RVA = "0x1F0D3D0", Offset = "0x1F0C7D0", Length = "0x19")]
		[Token(Token = "0x6001E0A")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170003BB")]
	internal object ObjectValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001E1A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B8")]
	internal bool Reachable
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6001E15")]
		internal get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x6001E16")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170003AF")]
	internal bool RequiresDelayedFixup
	{
		[Address(RVA = "0x1F0D350", Offset = "0x1F0C750", Length = "0x8")]
		[Token(Token = "0x6001E0B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003BF")]
	internal bool RequiresSerInfoFixup
	{
		[Address(RVA = "0x1F0D360", Offset = "0x1F0C760", Length = "0x14")]
		[Token(Token = "0x6001E21")]
		internal get { } //Length: 20
		[Address(RVA = "0x1F0D3F0", Offset = "0x1F0C7F0", Length = "0x1B")]
		[Token(Token = "0x6001E22")]
		internal set { } //Length: 27
	}

	[Token(Token = "0x170003B0")]
	internal bool RequiresValueTypeFixup
	{
		[Address(RVA = "0x1F0D380", Offset = "0x1F0C780", Length = "0x8")]
		[Token(Token = "0x6001E0C")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003BC")]
	internal SerializationInfo SerializationInfo
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001E1C")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6001E1D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003BD")]
	internal ISerializationSurrogate Surrogate
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001E1E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B7")]
	internal int TotalDependentObjects
	{
		[Address(RVA = "0x1E94DC0", Offset = "0x1E941C0", Length = "0x7")]
		[Token(Token = "0x6001E14")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170003BA")]
	internal TypeLoadExceptionHolder TypeLoadException
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001E18")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6001E19")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x170003B9")]
	internal bool TypeLoadExceptionReachable
	{
		[Address(RVA = "0x1F0D390", Offset = "0x1F0C790", Length = "0x9")]
		[Token(Token = "0x6001E17")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170003C0")]
	internal ValueTypeFixupInfo ValueFixup
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001E23")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B1")]
	internal bool ValueTypeFixupPerformed
	{
		[Address(RVA = "0x1F0D3A0", Offset = "0x1F0C7A0", Length = "0x29")]
		[Token(Token = "0x6001E0D")]
		internal get { } //Length: 41
		[Address(RVA = "0x1F0D410", Offset = "0x1F0C810", Length = "0xC")]
		[Token(Token = "0x6001E0E")]
		internal set { } //Length: 12
	}

	[Address(RVA = "0x1F0CDC0", Offset = "0x1F0C1C0", Length = "0xB1")]
	[Token(Token = "0x6001DFD")]
	internal ObjectHolder(long objID) { }

	[Address(RVA = "0x1F0CE80", Offset = "0x1F0C280", Length = "0x28A")]
	[Token(Token = "0x6001DFE")]
	internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[Address(RVA = "0x1F0D110", Offset = "0x1F0C510", Length = "0x11F")]
	[Token(Token = "0x6001DFF")]
	internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[Address(RVA = "0x1F0C790", Offset = "0x1F0BB90", Length = "0x8A")]
	[Token(Token = "0x6001E05")]
	internal void AddDependency(long dependentObject) { }

	[Address(RVA = "0x1F0C820", Offset = "0x1F0BC20", Length = "0xE4")]
	[Token(Token = "0x6001E03")]
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	[Address(RVA = "0x1F0C910", Offset = "0x1F0BD10", Length = "0x56")]
	[Token(Token = "0x6001E01")]
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	[Address(RVA = "0x1F0D230", Offset = "0x1F0C630", Length = "0x19")]
	[Token(Token = "0x6001E12")]
	internal bool get_CanObjectValueChange() { }

	[Address(RVA = "0x1F0D250", Offset = "0x1F0C650", Length = "0x85")]
	[Token(Token = "0x6001E11")]
	internal bool get_CanSurrogatedObjectValueChange() { }

	[Address(RVA = "0x1F0D2E0", Offset = "0x1F0C6E0", Length = "0x1E")]
	[Token(Token = "0x6001E24")]
	internal bool get_CompletelyFixed() { }

	[Address(RVA = "0x1F0D300", Offset = "0x1F0C700", Length = "0x13")]
	[Token(Token = "0x6001E25")]
	internal long get_ContainerID() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001E1F")]
	internal LongList get_DependentObjects() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6001E13")]
	internal int get_DirectlyDependentObjects() { }

	[Address(RVA = "0x1F0D320", Offset = "0x1F0C720", Length = "0x8")]
	[Token(Token = "0x6001E0F")]
	internal bool get_HasISerializable() { }

	[Address(RVA = "0x1F0D330", Offset = "0x1F0C730", Length = "0x8")]
	[Token(Token = "0x6001E10")]
	internal bool get_HasSurrogate() { }

	[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
	[Token(Token = "0x6001E09")]
	internal bool get_IsIncompleteObjectReference() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001E1A")]
	internal object get_ObjectValue() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6001E15")]
	internal bool get_Reachable() { }

	[Address(RVA = "0x1F0D350", Offset = "0x1F0C750", Length = "0x8")]
	[Token(Token = "0x6001E0B")]
	internal bool get_RequiresDelayedFixup() { }

	[Address(RVA = "0x1F0D360", Offset = "0x1F0C760", Length = "0x14")]
	[Token(Token = "0x6001E21")]
	internal bool get_RequiresSerInfoFixup() { }

	[Address(RVA = "0x1F0D380", Offset = "0x1F0C780", Length = "0x8")]
	[Token(Token = "0x6001E0C")]
	internal bool get_RequiresValueTypeFixup() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001E1C")]
	internal SerializationInfo get_SerializationInfo() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001E1E")]
	internal ISerializationSurrogate get_Surrogate() { }

	[Address(RVA = "0x1E94DC0", Offset = "0x1E941C0", Length = "0x7")]
	[Token(Token = "0x6001E14")]
	internal int get_TotalDependentObjects() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001E18")]
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	[Address(RVA = "0x1F0D390", Offset = "0x1F0C790", Length = "0x9")]
	[Token(Token = "0x6001E17")]
	internal bool get_TypeLoadExceptionReachable() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001E23")]
	internal ValueTypeFixupInfo get_ValueFixup() { }

	[Address(RVA = "0x1F0D3A0", Offset = "0x1F0C7A0", Length = "0x29")]
	[Token(Token = "0x6001E0D")]
	internal bool get_ValueTypeFixupPerformed() { }

	[Address(RVA = "0x1F0C970", Offset = "0x1F0BD70", Length = "0x4")]
	[Token(Token = "0x6001E00")]
	private void IncrementDescendentFixups(int amount) { }

	[Address(RVA = "0x1F0C980", Offset = "0x1F0BD80", Length = "0x5")]
	[Token(Token = "0x6001E07")]
	internal void MarkForCompletionWhenAvailable() { }

	[Address(RVA = "0x1F0C990", Offset = "0x1F0BD90", Length = "0x1E")]
	[Token(Token = "0x6001E02")]
	internal void RemoveDependency(long id) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6001E20")]
	internal void set_DependentObjects(LongList value) { }

	[Address(RVA = "0x1F0D3D0", Offset = "0x1F0C7D0", Length = "0x19")]
	[Token(Token = "0x6001E0A")]
	internal void set_IsIncompleteObjectReference(bool value) { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[Token(Token = "0x6001E16")]
	internal void set_Reachable(bool value) { }

	[Address(RVA = "0x1F0D3F0", Offset = "0x1F0C7F0", Length = "0x1B")]
	[Token(Token = "0x6001E22")]
	internal void set_RequiresSerInfoFixup(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6001E1D")]
	internal void set_SerializationInfo(SerializationInfo value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6001E19")]
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	[Address(RVA = "0x1F0D410", Offset = "0x1F0C810", Length = "0xC")]
	[Token(Token = "0x6001E0E")]
	internal void set_ValueTypeFixupPerformed(bool value) { }

	[Address(RVA = "0x1F0C9B0", Offset = "0x1F0BDB0", Length = "0x8C")]
	[Token(Token = "0x6001E08")]
	internal void SetFlags() { }

	[Address(RVA = "0x1F0CA40", Offset = "0x1F0BE40", Length = "0x129")]
	[Token(Token = "0x6001E1B")]
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	[Address(RVA = "0x1F0CB70", Offset = "0x1F0BF70", Length = "0x1E1")]
	[Token(Token = "0x6001E06")]
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Int32[] arrayIndex, ObjectManager manager) { }

	[Address(RVA = "0x1F0CD60", Offset = "0x1F0C160", Length = "0x58")]
	[Token(Token = "0x6001E04")]
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

}

