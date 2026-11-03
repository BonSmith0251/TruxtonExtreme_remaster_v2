//Type is in global namespace

[Token(Token = "0x2000006")]
internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	internal Action<Single> m_OnUpdateDelegate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000009")]
	internal Action<Single> m_OnLateUpdateDelegate; //Field offset: 0x28

	[Token(Token = "0x14000004")]
	internal event Action<Single> OnLateUpdateDelegate
	{
		[Address(RVA = "0x2E45C30", Offset = "0x2E45030", Length = "0xAF")]
		[Token(Token = "0x6000021")]
		internal add { } //Length: 175
		[Address(RVA = "0x2E45D90", Offset = "0x2E45190", Length = "0xAF")]
		[Token(Token = "0x6000022")]
		internal remove { } //Length: 175
	}

	[Token(Token = "0x14000003")]
	public event Action<Single> OnUpdateDelegate
	{
		[Address(RVA = "0x2E45CE0", Offset = "0x2E450E0", Length = "0xAF")]
		[Token(Token = "0x600001F")]
		 add { } //Length: 175
		[Address(RVA = "0x2E45E40", Offset = "0x2E45240", Length = "0xAF")]
		[Token(Token = "0x6000020")]
		 remove { } //Length: 175
	}

	[Address(RVA = "0x2E45BF0", Offset = "0x2E44FF0", Length = "0x39")]
	[Token(Token = "0x6000026")]
	public MonoBehaviourCallbackHooks() { }

	[Address(RVA = "0x2E45C30", Offset = "0x2E45030", Length = "0xAF")]
	[Token(Token = "0x6000021")]
	internal void add_OnLateUpdateDelegate(Action<Single> value) { }

	[Address(RVA = "0x2E45CE0", Offset = "0x2E450E0", Length = "0xAF")]
	[Token(Token = "0x600001F")]
	public void add_OnUpdateDelegate(Action<Single> value) { }

	[Address(RVA = "0x2E45B40", Offset = "0x2E44F40", Length = "0x2C")]
	[Token(Token = "0x6000023")]
	protected virtual string GetGameObjectName() { }

	[Address(RVA = "0x2E45B70", Offset = "0x2E44F70", Length = "0x33")]
	[Token(Token = "0x6000025")]
	internal void LateUpdate() { }

	[Address(RVA = "0x2E45D90", Offset = "0x2E45190", Length = "0xAF")]
	[Token(Token = "0x6000022")]
	internal void remove_OnLateUpdateDelegate(Action<Single> value) { }

	[Address(RVA = "0x2E45E40", Offset = "0x2E45240", Length = "0xAF")]
	[Token(Token = "0x6000020")]
	public void remove_OnUpdateDelegate(Action<Single> value) { }

	[Address(RVA = "0x2E45BB0", Offset = "0x2E44FB0", Length = "0x33")]
	[Token(Token = "0x6000024")]
	internal void Update() { }

}

