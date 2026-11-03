namespace UnityEngine.Rendering;

[AddComponentMenu(null)]
[ExecuteAlways]
[Token(Token = "0x2000138")]
public class ProbeVolumePerSceneData : MonoBehaviour
{
	[Token(Token = "0x2000139")]
	public struct ObsoletePerScenarioData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EB")]
		public int sceneHash; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005EC")]
		public TextAsset cellDataAsset; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005ED")]
		public TextAsset cellOptionalDataAsset; //Field offset: 0x10

	}

	[Token(Token = "0x200013A")]
	private struct ObsoleteSerializablePerScenarioDataItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EE")]
		public string scenario; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005EF")]
		public ObsoletePerScenarioData data; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("bakingSet")]
	[SerializeField]
	[Token(Token = "0x40005E5")]
	internal ProbeVolumeBakingSet serializedBakingSet; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005E6")]
	internal string sceneGUID; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("asset")]
	[SerializeField]
	[Token(Token = "0x40005E7")]
	internal ObsoleteProbeVolumeAsset obsoleteAsset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("cellSharedDataAsset")]
	[SerializeField]
	[Token(Token = "0x40005E8")]
	internal TextAsset obsoleteCellSharedDataAsset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("cellSupportDataAsset")]
	[SerializeField]
	[Token(Token = "0x40005E9")]
	internal TextAsset obsoleteCellSupportDataAsset; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("serializedScenarios")]
	[SerializeField]
	[Token(Token = "0x40005EA")]
	private List<ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios; //Field offset: 0x48

	[Token(Token = "0x1700013A")]
	public ProbeVolumeBakingSet bakingSet
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000AA4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C1BBA0", Offset = "0x2C1AFA0", Length = "0x9E")]
	[Token(Token = "0x6000AAD")]
	public ProbeVolumePerSceneData() { }

	[Address(RVA = "0x2C1B5F0", Offset = "0x2C1A9F0", Length = "0x28")]
	[Token(Token = "0x6000AA5")]
	internal void Clear() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000AA4")]
	public ProbeVolumeBakingSet get_bakingSet() { }

	[Address(RVA = "0x2C1B620", Offset = "0x2C1AA20", Length = "0x174")]
	[Token(Token = "0x6000AAB")]
	internal void Initialize() { }

	[Address(RVA = "0x2C1B7A0", Offset = "0x2C1ABA0", Length = "0xA1")]
	[Token(Token = "0x6000AA9")]
	private void OnDisable() { }

	[Address(RVA = "0x2C1B850", Offset = "0x2C1AC50", Length = "0x97")]
	[Token(Token = "0x6000AA8")]
	private void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AAA")]
	private void OnValidate() { }

	[Address(RVA = "0x2C1B8F0", Offset = "0x2C1ACF0", Length = "0xDC")]
	[Token(Token = "0x6000AA6")]
	internal void QueueSceneLoading() { }

	[Address(RVA = "0x2C1B9D0", Offset = "0x2C1ADD0", Length = "0xD8")]
	[Token(Token = "0x6000AA7")]
	internal void QueueSceneRemoval() { }

	[Address(RVA = "0x2C1BAB0", Offset = "0x2C1AEB0", Length = "0xEE")]
	[Token(Token = "0x6000AAC")]
	internal bool ResolveCellData() { }

}

