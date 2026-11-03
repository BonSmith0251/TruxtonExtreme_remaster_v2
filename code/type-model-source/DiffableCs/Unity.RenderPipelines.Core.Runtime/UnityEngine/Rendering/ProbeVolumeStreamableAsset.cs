namespace UnityEngine.Rendering;

[MovedFrom(False, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset")]
[Token(Token = "0x2000142")]
internal class ProbeVolumeStreamableAsset
{
	[MovedFrom(False, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset.StreamableCellDesc")]
	[Token(Token = "0x2000143")]
	internal struct StreamableCellDesc
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061A")]
		public int offset; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400061B")]
		public int elementCount; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("assetGUID")]
	[SerializeField]
	[Token(Token = "0x4000613")]
	private string m_AssetGUID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("streamableAssetPath")]
	[SerializeField]
	[Token(Token = "0x4000614")]
	private string m_StreamableAssetPath; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("elementSize")]
	[SerializeField]
	[Token(Token = "0x4000615")]
	private int m_ElementSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("streamableCellDescs")]
	[SerializeField]
	[Token(Token = "0x4000616")]
	private SerializedDictionary<Int32, StreamableCellDesc> m_StreamableCellDescs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000617")]
	private TextAsset m_Asset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000618")]
	private string m_FinalAssetPath; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000619")]
	private FileHandle m_AssetFileHandle; //Field offset: 0x40

	[Token(Token = "0x1700013F")]
	public TextAsset asset
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000ACB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013E")]
	public string assetGUID
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000ACA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000140")]
	public int elementSize
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000ACC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000141")]
	public SerializedDictionary<Int32, StreamableCellDesc> streamableCellDescs
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000ACD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C30E00", Offset = "0x2C30200", Length = "0x179")]
	[Token(Token = "0x6000ACE")]
	public ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, SerializedDictionary<Int32, StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID) { }

	[Address(RVA = "0x2C30930", Offset = "0x2C2FD30", Length = "0x7A")]
	[Token(Token = "0x6000AD6")]
	public void CloseFile() { }

	[Address(RVA = "0x2C309B0", Offset = "0x2C2FDB0", Length = "0x65")]
	[Token(Token = "0x6000AD8")]
	public void Dispose() { }

	[Address(RVA = "0x2C30A20", Offset = "0x2C2FE20", Length = "0xD5")]
	[Token(Token = "0x6000AD2")]
	public bool FileExists() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000ACB")]
	public TextAsset get_asset() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000ACA")]
	public string get_assetGUID() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000ACC")]
	public int get_elementSize() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000ACD")]
	public SerializedDictionary<Int32, StreamableCellDesc> get_streamableCellDescs() { }

	[Address(RVA = "0x2C30B00", Offset = "0x2C2FF00", Length = "0xB8")]
	[Token(Token = "0x6000AD0")]
	public string GetAssetPath() { }

	[Address(RVA = "0x2C30BC0", Offset = "0x2C2FFC0", Length = "0x71")]
	[Token(Token = "0x6000AD3")]
	public long GetFileSize() { }

	[Address(RVA = "0x2C30C40", Offset = "0x2C30040", Length = "0x84")]
	[Token(Token = "0x6000AD1")]
	internal bool HasValidAssetReference() { }

	[Address(RVA = "0x2C30CD0", Offset = "0x2C300D0", Length = "0xB")]
	[Token(Token = "0x6000AD4")]
	public bool IsOpen() { }

	[Address(RVA = "0x2C30CE0", Offset = "0x2C300E0", Length = "0x16")]
	[Token(Token = "0x6000AD7")]
	public bool IsValid() { }

	[Address(RVA = "0x2C30D00", Offset = "0x2C30100", Length = "0x55")]
	[Token(Token = "0x6000AD5")]
	public FileHandle OpenFile() { }

	[Address(RVA = "0x2C30D60", Offset = "0x2C30160", Length = "0x9F")]
	[Token(Token = "0x6000ACF")]
	internal void RefreshAssetPath() { }

}

