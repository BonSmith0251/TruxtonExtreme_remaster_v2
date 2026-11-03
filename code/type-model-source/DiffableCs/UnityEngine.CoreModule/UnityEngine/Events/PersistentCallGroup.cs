namespace UnityEngine.Events;

[Token(Token = "0x200023E")]
internal class PersistentCallGroup
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	[Token(Token = "0x40007A3")]
	private List<PersistentCall> m_Calls; //Field offset: 0x10

	[Address(RVA = "0x307A440", Offset = "0x3079840", Length = "0x77")]
	[Token(Token = "0x60017E8")]
	public PersistentCallGroup() { }

	[Address(RVA = "0x307A2B0", Offset = "0x30796B0", Length = "0x182")]
	[Token(Token = "0x60017E9")]
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

