namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000036")]
public class AssetReference : IKeyEvaluator
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_assetGUID")]
	[SerializeField]
	[Token(Token = "0x40000AF")]
	protected private string m_AssetGUID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000B0")]
	private string m_SubObjectName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000B1")]
	private string m_SubObjectType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B2")]
	private AsyncOperationHandle m_Operation; //Field offset: 0x28

	[Token(Token = "0x17000032")]
	public override object Asset
	{
		[Address(RVA = "0x27A5A80", Offset = "0x27A4E80", Length = "0x93")]
		[Token(Token = "0x6000176")]
		 get { } //Length: 147
	}

	[Token(Token = "0x1700002E")]
	public override string AssetGUID
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600016E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000031")]
	public bool IsDone
	{
		[Address(RVA = "0x27A5B20", Offset = "0x27A4F20", Length = "0xB")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700002C")]
	public internal AsyncOperationHandle OperationHandle
	{
		[Address(RVA = "0xB00090", Offset = "0xAFF490", Length = "0x15")]
		[Token(Token = "0x600016B")]
		 get { } //Length: 21
		[Address(RVA = "0xB002E0", Offset = "0xAFF6E0", Length = "0x1C")]
		[Token(Token = "0x600016C")]
		internal set { } //Length: 28
	}

	[Token(Token = "0x1700002D")]
	public override object RuntimeKey
	{
		[Address(RVA = "0x27A5B30", Offset = "0x27A4F30", Length = "0x7E")]
		[Token(Token = "0x600016D")]
		 get { } //Length: 126
	}

	[Token(Token = "0x1700002F")]
	public override string SubObjectName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600016F")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000170")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000030")]
	internal override Type SubObjectType
	{
		[Address(RVA = "0x27A5BB0", Offset = "0x27A4FB0", Length = "0x83")]
		[Token(Token = "0x6000171")]
		internal get { } //Length: 131
	}

	[Address(RVA = "0x27A5A10", Offset = "0x27A4E10", Length = "0x6B")]
	[Token(Token = "0x6000175")]
	public AssetReference(string guid) { }

	[Address(RVA = "0x27A59C0", Offset = "0x27A4DC0", Length = "0x4F")]
	[Token(Token = "0x6000174")]
	public AssetReference() { }

	[Address(RVA = "0x7350C0", Offset = "0x7344C0", Length = "0x1BD")]
	[Token(Token = "0x6000178")]
	private static AsyncOperationHandle<T> CreateFailedOperation() { }

	[Address(RVA = "0x27A5A80", Offset = "0x27A4E80", Length = "0x93")]
	[Token(Token = "0x6000176")]
	public override object get_Asset() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600016E")]
	public override string get_AssetGUID() { }

	[Address(RVA = "0x27A5B20", Offset = "0x27A4F20", Length = "0xB")]
	[Token(Token = "0x6000173")]
	public bool get_IsDone() { }

	[Address(RVA = "0xB00090", Offset = "0xAFF490", Length = "0x15")]
	[Token(Token = "0x600016B")]
	public AsyncOperationHandle get_OperationHandle() { }

	[Address(RVA = "0x27A5B30", Offset = "0x27A4F30", Length = "0x7E")]
	[Token(Token = "0x600016D")]
	public override object get_RuntimeKey() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600016F")]
	public override string get_SubObjectName() { }

	[Address(RVA = "0x27A5BB0", Offset = "0x27A4FB0", Length = "0x83")]
	[Token(Token = "0x6000171")]
	internal override Type get_SubObjectType() { }

	[Address(RVA = "0x27A5160", Offset = "0x27A4560", Length = "0x19A")]
	[Token(Token = "0x600017D")]
	public override AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false) { }

	[Address(RVA = "0x27A4FA0", Offset = "0x27A43A0", Length = "0x1BE")]
	[Token(Token = "0x600017C")]
	public override AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null) { }

	[Address(RVA = "0x27A5300", Offset = "0x27A4700", Length = "0xB")]
	[Token(Token = "0x6000172")]
	public bool IsValid() { }

	[Address(RVA = "0x7353D0", Offset = "0x7347D0", Length = "0x14D")]
	[Token(Token = "0x6000179")]
	public override AsyncOperationHandle<TObject> LoadAssetAsync() { }

	[Address(RVA = "0x27A5310", Offset = "0x27A4710", Length = "0x237")]
	[Token(Token = "0x600017A")]
	public override AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100) { }

	[Address(RVA = "0x27A5550", Offset = "0x27A4950", Length = "0x86")]
	[Token(Token = "0x600017F")]
	public override void ReleaseAsset() { }

	[Address(RVA = "0x27A55E0", Offset = "0x27A49E0", Length = "0x1BA")]
	[Token(Token = "0x6000180")]
	public override void ReleaseInstance(GameObject obj) { }

	[Address(RVA = "0x27A57A0", Offset = "0x27A4BA0", Length = "0x88")]
	[Token(Token = "0x600017E")]
	public override bool RuntimeKeyIsValid() { }

	[Address(RVA = "0xB002E0", Offset = "0xAFF6E0", Length = "0x1C")]
	[Token(Token = "0x600016C")]
	internal void set_OperationHandle(AsyncOperationHandle value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000170")]
	public override void set_SubObjectName(string value) { }

	[Address(RVA = "0x27A5830", Offset = "0x27A4C30", Length = "0x50")]
	[Token(Token = "0x6000177")]
	public virtual string ToString() { }

	[Address(RVA = "0x27A5880", Offset = "0x27A4C80", Length = "0x130")]
	[Token(Token = "0x600017B")]
	public override AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000181")]
	public override bool ValidateAsset(object obj) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000182")]
	public override bool ValidateAsset(string path) { }

}

