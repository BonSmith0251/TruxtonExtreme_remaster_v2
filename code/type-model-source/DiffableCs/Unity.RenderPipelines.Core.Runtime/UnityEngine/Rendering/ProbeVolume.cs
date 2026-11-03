namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Adaptive Probe Volume")]
[ExecuteAlways]
[Token(Token = "0x2000122")]
public class ProbeVolume : MonoBehaviour
{
	[Token(Token = "0x2000123")]
	internal enum Mode : int
	{
		Global = 0,
		Scene = 1,
		Local = 2,
	}

	[Token(Token = "0x2000124")]
	private enum Version : int
	{
		Initial = 0,
		LocalMode = 1,
		InvertOverrideLevels = 2,
		Count = 3,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000548")]
	[Tooltip("When set to Global this Probe Volume considers all renderers with Contribute Global Illumination enabled. Local only considers renderers in the scene.\nThis list updates every time the Scene is saved or the lighting is baked.")]
	public Mode mode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000549")]
	public Vector3 size; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[Min(0)]
	[Token(Token = "0x400054A")]
	public bool overrideRendererFilters; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	[Min(0)]
	[Token(Token = "0x400054B")]
	public float minRendererVolumeSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400054C")]
	public LayerMask objectLayerMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	[Token(Token = "0x400054D")]
	public int lowestSubdivLevelOverride; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[Token(Token = "0x400054E")]
	public int highestSubdivLevelOverride; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	[Token(Token = "0x400054F")]
	public bool overridesSubdivLevels; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	[Token(Token = "0x4000550")]
	internal bool mightNeedRebaking; //Field offset: 0x45
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000551")]
	internal Matrix4x4 cachedTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000552")]
	internal int cachedHashCode; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	[Token(Token = "0x4000553")]
	[Tooltip("Whether Unity should fill empty space between renderers with bricks at the highest subdivision level.")]
	public bool fillEmptySpaces; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000554")]
	private Version version; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Obsolete("Use mode instead. #from(2023.1)")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	public bool globalVolume; //Field offset: 0x94

	[Address(RVA = "0x2C1D100", Offset = "0x2C1C500", Length = "0x54")]
	[Token(Token = "0x6000A47")]
	public ProbeVolume() { }

	[Address(RVA = "0x2C1D0C0", Offset = "0x2C1C4C0", Length = "0x39")]
	[Token(Token = "0x6000A46")]
	private void Awake() { }

}

