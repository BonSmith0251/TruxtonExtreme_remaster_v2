namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
[Token(Token = "0x200023C")]
internal struct CallbackArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C75")]
	private bool m_CannotMutateCallbacksArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C76")]
	private InlinedArray<TDelegate> m_Callbacks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C77")]
	private InlinedArray<TDelegate> m_CallbacksToAdd; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C78")]
	private InlinedArray<TDelegate> m_CallbacksToRemove; //Field offset: 0x0

	[Token(Token = "0x170005F3")]
	public TDelegate Item
	{
		[Address(RVA = "0x16C4010", Offset = "0x16C3410", Length = "0x44")]
		[Token(Token = "0x6001502")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170005F2")]
	public int length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001501")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x16C3920", Offset = "0x16C2D20", Length = "0x1A5")]
	[Token(Token = "0x6001504")]
	public void AddCallback(TDelegate dlg) { }

	[Address(RVA = "0x16C3AD0", Offset = "0x16C2ED0", Length = "0x95")]
	[Token(Token = "0x6001503")]
	public void Clear() { }

	[Address(RVA = "0x16C4010", Offset = "0x16C3410", Length = "0x44")]
	[Token(Token = "0x6001502")]
	public TDelegate get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6001501")]
	public int get_length() { }

	[Address(RVA = "0x16C3B70", Offset = "0x16C2F70", Length = "0x4")]
	[Token(Token = "0x6001506")]
	public void LockForChanges() { }

	[Address(RVA = "0x16C3B80", Offset = "0x16C2F80", Length = "0x192")]
	[Token(Token = "0x6001505")]
	public void RemoveCallback(TDelegate dlg) { }

	[Address(RVA = "0x16C3D20", Offset = "0x16C3120", Length = "0x2E1")]
	[Token(Token = "0x6001507")]
	public void UnlockForChanges() { }

}

