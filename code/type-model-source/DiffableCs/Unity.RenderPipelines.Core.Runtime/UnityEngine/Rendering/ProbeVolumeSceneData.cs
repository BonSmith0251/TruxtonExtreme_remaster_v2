namespace UnityEngine.Rendering;

[Obsolete("This class is no longer necessary for APV implementation. #from(2023.3)")]
[Token(Token = "0x200013C")]
public class ProbeVolumeSceneData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F2")]
	internal object parentAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("sceneBounds")]
	[Obsolete("This data is now serialized directly in the baking set asset. #from(2023.3)")]
	[SerializeField]
	[Token(Token = "0x40005F3")]
	internal SerializedDictionary<String, Bounds> obsoleteSceneBounds; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("hasProbeVolumes")]
	[Obsolete("This data is now serialized directly in the baking set asset. #from(2023.3)")]
	[SerializeField]
	[Token(Token = "0x40005F4")]
	internal SerializedDictionary<String, Boolean> obsoleteHasProbeVolumes; //Field offset: 0x20

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000AB4")]
	public ProbeVolumeSceneData(object parentAsset) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Obsolete("#from(2023.3)")]
	[Token(Token = "0x6000AB5")]
	public void SetParentObject(object parent) { }

}

