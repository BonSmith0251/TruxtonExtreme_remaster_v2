namespace UnityEngine.Events;

[Token(Token = "0x200023D")]
internal class PersistentCall : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("instance")]
	[SerializeField]
	[Token(Token = "0x400079D")]
	private object m_Target; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400079E")]
	private string m_TargetAssemblyTypeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	[Token(Token = "0x400079F")]
	private string m_MethodName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("mode")]
	[SerializeField]
	[Token(Token = "0x40007A0")]
	private PersistentListenerMode m_Mode; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	[Token(Token = "0x40007A1")]
	private ArgumentCache m_Arguments; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Enabled")]
	[FormerlySerializedAs("enabled")]
	[SerializeField]
	[Token(Token = "0x40007A2")]
	private UnityEventCallState m_CallState; //Field offset: 0x38

	[Token(Token = "0x1700038C")]
	public ArgumentCache arguments
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60017E1")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700038A")]
	public string methodName
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60017DF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700038B")]
	public PersistentListenerMode mode
	{
		[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
		[Token(Token = "0x60017E0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000388")]
	public object target
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60017DD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000389")]
	public string targetAssemblyTypeName
	{
		[Address(RVA = "0x307ADA0", Offset = "0x307A1A0", Length = "0xBD")]
		[Token(Token = "0x60017DE")]
		 get { } //Length: 189
	}

	[Address(RVA = "0x307AD20", Offset = "0x307A120", Length = "0x74")]
	[Token(Token = "0x60017E7")]
	public PersistentCall() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60017E1")]
	public ArgumentCache get_arguments() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60017DF")]
	public string get_methodName() { }

	[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
	[Token(Token = "0x60017E0")]
	public PersistentListenerMode get_mode() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60017DD")]
	public object get_target() { }

	[Address(RVA = "0x307ADA0", Offset = "0x307A1A0", Length = "0xBD")]
	[Token(Token = "0x60017DE")]
	public string get_targetAssemblyTypeName() { }

	[Address(RVA = "0x307A4C0", Offset = "0x30798C0", Length = "0x509")]
	[Token(Token = "0x60017E4")]
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	[Address(RVA = "0x307A9D0", Offset = "0x3079DD0", Length = "0x2EC")]
	[Token(Token = "0x60017E3")]
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	[Address(RVA = "0x307ACE0", Offset = "0x307A0E0", Length = "0x39")]
	[Token(Token = "0x60017E2")]
	public bool IsValid() { }

	[Address(RVA = "0x3076910", Offset = "0x3075D10", Length = "0x29")]
	[Token(Token = "0x60017E6")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x3076910", Offset = "0x3075D10", Length = "0x29")]
	[Token(Token = "0x60017E5")]
	public override void OnBeforeSerialize() { }

}

