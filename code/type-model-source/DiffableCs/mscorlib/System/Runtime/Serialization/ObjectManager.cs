namespace System.Runtime.Serialization;

[ComVisible(True)]
[Token(Token = "0x20003E9")]
public class ObjectManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F47")]
	private DeserializationEventHandler m_onDeserializationHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F48")]
	private SerializationEventHandler m_onDeserializedHandler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F49")]
	internal ObjectHolder[] m_objects; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F4A")]
	internal object m_topObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F4B")]
	internal ObjectHolderList m_specialFixupObjects; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F4C")]
	internal long m_fixupCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F4D")]
	internal ISurrogateSelector m_selector; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F4E")]
	internal StreamingContext m_context; //Field offset: 0x48

	[Token(Token = "0x170003AD")]
	internal ObjectHolderList SpecialFixupObjects
	{
		[Address(RVA = "0x1F11E20", Offset = "0x1F11220", Length = "0x69")]
		[Token(Token = "0x6001DE4")]
		internal get { } //Length: 105
	}

	[Token(Token = "0x170003AC")]
	internal object TopObject
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001DE3")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6001DE2")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1F11D90", Offset = "0x1F11190", Length = "0x90")]
	[Token(Token = "0x6001DE0")]
	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	[Address(RVA = "0x1F0DBF0", Offset = "0x1F0CFF0", Length = "0x134")]
	[Token(Token = "0x6001DE7")]
	private void AddObjectHolder(ObjectHolder holder) { }

	[Address(RVA = "0x1F0DD30", Offset = "0x1F0D130", Length = "0x9F")]
	[Token(Token = "0x6001DF9")]
	internal override void AddOnDeserialization(DeserializationEventHandler handler) { }

	[Address(RVA = "0x1F0DDD0", Offset = "0x1F0D1D0", Length = "0x9E")]
	[Token(Token = "0x6001DFA")]
	internal override void AddOnDeserialized(object obj) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001DE1")]
	private bool CanCallGetType(object obj) { }

	[Address(RVA = "0x1F0DE70", Offset = "0x1F0D270", Length = "0x362")]
	[Token(Token = "0x6001DF1")]
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F0E1E0", Offset = "0x1F0D5E0", Length = "0xFD8")]
	[Token(Token = "0x6001DEC")]
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	[Address(RVA = "0x1F0F1C0", Offset = "0x1F0E5C0", Length = "0x433")]
	[Token(Token = "0x6001DF3")]
	public override void DoFixups() { }

	[Address(RVA = "0x1F0F600", Offset = "0x1F0EA00", Length = "0x14D")]
	[Token(Token = "0x6001DED")]
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	[Address(RVA = "0x1F0F750", Offset = "0x1F0EB50", Length = "0x649")]
	[Token(Token = "0x6001DEB")]
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	[Address(RVA = "0x1F0FDA0", Offset = "0x1F0F1A0", Length = "0x4C")]
	[Token(Token = "0x6001DE5")]
	internal ObjectHolder FindObjectHolder(long objectID) { }

	[Address(RVA = "0x1F0FDF0", Offset = "0x1F0F1F0", Length = "0x145")]
	[Token(Token = "0x6001DE6")]
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	[Address(RVA = "0x1F0FF40", Offset = "0x1F0F340", Length = "0x396")]
	[Token(Token = "0x6001DE9")]
	private void FixupSpecialObject(ObjectHolder holder) { }

	[Address(RVA = "0x1F11E20", Offset = "0x1F11220", Length = "0x69")]
	[Token(Token = "0x6001DE4")]
	internal ObjectHolderList get_SpecialFixupObjects() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001DE3")]
	internal object get_TopObject() { }

	[Address(RVA = "0x1F102E0", Offset = "0x1F0F6E0", Length = "0x3AA")]
	[Token(Token = "0x6001DE8")]
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	[Address(RVA = "0x1F10690", Offset = "0x1F0FA90", Length = "0x123")]
	[Token(Token = "0x6001DF2")]
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	[Address(RVA = "0x1F107C0", Offset = "0x1F0FBC0", Length = "0xE9")]
	[Token(Token = "0x6001DEE")]
	public override object GetObject(long objectID) { }

	[Address(RVA = "0x1F108B0", Offset = "0x1F0FCB0", Length = "0x57")]
	[Token(Token = "0x6001DF8")]
	public override void RaiseDeserializationEvent() { }

	[Address(RVA = "0x1F10910", Offset = "0x1F0FD10", Length = "0xBE")]
	[Token(Token = "0x6001DFB")]
	internal override void RaiseOnDeserializedEvent(object obj) { }

	[Address(RVA = "0x1F109D0", Offset = "0x1F0FDD0", Length = "0xBE")]
	[Token(Token = "0x6001DFC")]
	public void RaiseOnDeserializingEvent(object obj) { }

	[Address(RVA = "0x1F10A90", Offset = "0x1F0FE90", Length = "0x173")]
	[Token(Token = "0x6001DF7")]
	public override void RecordArrayElementFixup(long arrayToBeFixed, Int32[] indices, long objectRequired) { }

	[Address(RVA = "0x1F10C10", Offset = "0x1F10010", Length = "0x173")]
	[Token(Token = "0x6001DF6")]
	public override void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	[Address(RVA = "0x1F10D90", Offset = "0x1F10190", Length = "0x2AC")]
	[Token(Token = "0x6001DF5")]
	public override void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	[Address(RVA = "0x1F11040", Offset = "0x1F10440", Length = "0x202")]
	[Token(Token = "0x6001DF4")]
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	[Address(RVA = "0x1F11250", Offset = "0x1F10650", Length = "0x7F6")]
	[Token(Token = "0x6001DF0")]
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Int32[] arrayIndex) { }

	[Address(RVA = "0x1F11A50", Offset = "0x1F10E50", Length = "0xFE")]
	[Token(Token = "0x6001DEF")]
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	[Address(RVA = "0x1F11B50", Offset = "0x1F10F50", Length = "0x23A")]
	[Token(Token = "0x6001DEA")]
	private bool ResolveObjectReference(ObjectHolder holder) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6001DE2")]
	internal void set_TopObject(object value) { }

}

