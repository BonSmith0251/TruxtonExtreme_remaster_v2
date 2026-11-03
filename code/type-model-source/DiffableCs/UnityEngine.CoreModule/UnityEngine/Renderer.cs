namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000EC")]
[UsedByNativeCode]
public class Renderer : Component
{

	[Token(Token = "0x17000159")]
	internal bool allowGPUDrivenRendering
	{
		[Address(RVA = "0x3012E80", Offset = "0x3012280", Length = "0x86")]
		[Token(Token = "0x600077D")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x17000154")]
	public Bounds bounds
	{
		[Address(RVA = "0x30129D0", Offset = "0x3011DD0", Length = "0x94")]
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		[Token(Token = "0x600076F")]
		 get { } //Length: 148
	}

	[Token(Token = "0x17000156")]
	public bool enabled
	{
		[Address(RVA = "0x3012AB0", Offset = "0x3011EB0", Length = "0x76")]
		[Token(Token = "0x6000779")]
		 get { } //Length: 118
		[Address(RVA = "0x3012F60", Offset = "0x3012360", Length = "0x86")]
		[Token(Token = "0x600077A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000155")]
	public Bounds localBounds
	{
		[Address(RVA = "0x3013040", Offset = "0x3012440", Length = "0x85")]
		[NativeName("SetLocalAABB")]
		[Token(Token = "0x6000770")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000161")]
	public Material material
	{
		[Address(RVA = "0x30122A0", Offset = "0x30116A0", Length = "0x90")]
		[Token(Token = "0x6000788")]
		 get { } //Length: 144
		[Address(RVA = "0x30128C0", Offset = "0x3011CC0", Length = "0xBA")]
		[Token(Token = "0x6000789")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000160")]
	public Material[] materials
	{
		[Address(RVA = "0x30121E0", Offset = "0x30115E0", Length = "0x76")]
		[Token(Token = "0x6000787")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000158")]
	public bool receiveShadows
	{
		[Address(RVA = "0x3013120", Offset = "0x3012520", Length = "0x86")]
		[Token(Token = "0x600077C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000157")]
	public ShadowCastingMode shadowCastingMode
	{
		[Address(RVA = "0x30131F0", Offset = "0x30125F0", Length = "0x83")]
		[Token(Token = "0x600077B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000162")]
	public Material sharedMaterial
	{
		[Address(RVA = "0x3012440", Offset = "0x3011840", Length = "0x90")]
		[Token(Token = "0x600078A")]
		 get { } //Length: 144
		[Address(RVA = "0x30128C0", Offset = "0x3011CC0", Length = "0xBA")]
		[Token(Token = "0x600078B")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000163")]
	public Material[] sharedMaterials
	{
		[Address(RVA = "0x3012380", Offset = "0x3011780", Length = "0x76")]
		[Token(Token = "0x600078C")]
		 get { } //Length: 118
		[Address(RVA = "0x3012790", Offset = "0x3011B90", Length = "0xDE")]
		[Token(Token = "0x600078D")]
		 set { } //Length: 222
	}

	[Token(Token = "0x1700015A")]
	internal bool smallMeshCulling
	{
		[Address(RVA = "0x30132D0", Offset = "0x30126D0", Length = "0x86")]
		[Token(Token = "0x600077E")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x1700015E")]
	internal int sortingGroupID
	{
		[Address(RVA = "0x3012B70", Offset = "0x3011F70", Length = "0x76")]
		[Token(Token = "0x6000784")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700015F")]
	internal int sortingGroupOrder
	{
		[Address(RVA = "0x3012C30", Offset = "0x3012030", Length = "0x76")]
		[Token(Token = "0x6000785")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700015C")]
	public int sortingLayerID
	{
		[Address(RVA = "0x3012CF0", Offset = "0x30120F0", Length = "0x76")]
		[Token(Token = "0x6000780")]
		 get { } //Length: 118
		[Address(RVA = "0x30133A0", Offset = "0x30127A0", Length = "0x83")]
		[Token(Token = "0x6000781")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700015B")]
	public string sortingLayerName
	{
		[Address(RVA = "0x3013480", Offset = "0x3012880", Length = "0x1C7")]
		[Token(Token = "0x600077F")]
		 set { } //Length: 455
	}

	[Token(Token = "0x1700015D")]
	public int sortingOrder
	{
		[Address(RVA = "0x3012DB0", Offset = "0x30121B0", Length = "0x76")]
		[Token(Token = "0x6000782")]
		 get { } //Length: 118
		[Address(RVA = "0x3013690", Offset = "0x3012A90", Length = "0x83")]
		[Token(Token = "0x6000783")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600078E")]
	public Renderer() { }

	[Address(RVA = "0x30129D0", Offset = "0x3011DD0", Length = "0x94")]
	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	[Token(Token = "0x600076F")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x3012980", Offset = "0x3011D80", Length = "0x42")]
	[Token(Token = "0x600078F")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x3012AB0", Offset = "0x3011EB0", Length = "0x76")]
	[Token(Token = "0x6000779")]
	public bool get_enabled() { }

	[Address(RVA = "0x3012A70", Offset = "0x3011E70", Length = "0x33")]
	[Token(Token = "0x6000798")]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30122A0", Offset = "0x30116A0", Length = "0x90")]
	[Token(Token = "0x6000788")]
	public Material get_material() { }

	[Address(RVA = "0x30121E0", Offset = "0x30115E0", Length = "0x76")]
	[Token(Token = "0x6000787")]
	public Material[] get_materials() { }

	[Address(RVA = "0x3012440", Offset = "0x3011840", Length = "0x90")]
	[Token(Token = "0x600078A")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x3012380", Offset = "0x3011780", Length = "0x76")]
	[Token(Token = "0x600078C")]
	public Material[] get_sharedMaterials() { }

	[Address(RVA = "0x3012B70", Offset = "0x3011F70", Length = "0x76")]
	[Token(Token = "0x6000784")]
	internal int get_sortingGroupID() { }

	[Address(RVA = "0x3012B30", Offset = "0x3011F30", Length = "0x33")]
	[Token(Token = "0x60007A3")]
	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012C30", Offset = "0x3012030", Length = "0x76")]
	[Token(Token = "0x6000785")]
	internal int get_sortingGroupOrder() { }

	[Address(RVA = "0x3012BF0", Offset = "0x3011FF0", Length = "0x33")]
	[Token(Token = "0x60007A4")]
	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012CF0", Offset = "0x30120F0", Length = "0x76")]
	[Token(Token = "0x6000780")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x3012CB0", Offset = "0x30120B0", Length = "0x33")]
	[Token(Token = "0x600079F")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012DB0", Offset = "0x30121B0", Length = "0x76")]
	[Token(Token = "0x6000782")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x3012D70", Offset = "0x3012170", Length = "0x33")]
	[Token(Token = "0x60007A1")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30122A0", Offset = "0x30116A0", Length = "0x90")]
	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	[Token(Token = "0x6000771")]
	private Material GetMaterial() { }

	[Address(RVA = "0x3012260", Offset = "0x3011660", Length = "0x33")]
	[Token(Token = "0x6000791")]
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30121E0", Offset = "0x30115E0", Length = "0x76")]
	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	[Token(Token = "0x6000774")]
	private Material[] GetMaterialArray() { }

	[Address(RVA = "0x30121A0", Offset = "0x30115A0", Length = "0x33")]
	[Token(Token = "0x6000794")]
	private static Material[] GetMaterialArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012440", Offset = "0x3011840", Length = "0x90")]
	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	[Token(Token = "0x6000772")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x3012400", Offset = "0x3011800", Length = "0x33")]
	[Token(Token = "0x6000792")]
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012380", Offset = "0x3011780", Length = "0x76")]
	[NativeName("GetMaterialArray")]
	[Token(Token = "0x6000786")]
	private Material[] GetSharedMaterialArray() { }

	[Address(RVA = "0x3012340", Offset = "0x3011740", Length = "0x33")]
	[Token(Token = "0x60007A5")]
	private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3012520", Offset = "0x3011920", Length = "0x76")]
	[NativeName("Renderer::GetMaskInteraction")]
	[Token(Token = "0x6000777")]
	internal SpriteMaskInteraction Internal_GetSpriteMaskInteraction() { }

	[Address(RVA = "0x30124E0", Offset = "0x30118E0", Length = "0x33")]
	[Token(Token = "0x6000796")]
	private static SpriteMaskInteraction Internal_GetSpriteMaskInteraction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30125E0", Offset = "0x30119E0", Length = "0x83")]
	[NativeName("Renderer::SetMaskInteraction")]
	[Token(Token = "0x6000778")]
	internal void Internal_SetSpriteMaskInteraction(SpriteMaskInteraction maskInteraction) { }

	[Address(RVA = "0x30125A0", Offset = "0x30119A0", Length = "0x40")]
	[Token(Token = "0x6000797")]
	private static void Internal_SetSpriteMaskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction maskInteraction) { }

	[Address(RVA = "0x3012E80", Offset = "0x3012280", Length = "0x86")]
	[Token(Token = "0x600077D")]
	internal void set_allowGPUDrivenRendering(bool value) { }

	[Address(RVA = "0x3012E30", Offset = "0x3012230", Length = "0x42")]
	[Token(Token = "0x600079C")]
	private static void set_allowGPUDrivenRendering_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3012F60", Offset = "0x3012360", Length = "0x86")]
	[Token(Token = "0x600077A")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x3012F10", Offset = "0x3012310", Length = "0x42")]
	[Token(Token = "0x6000799")]
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3013040", Offset = "0x3012440", Length = "0x85")]
	[NativeName("SetLocalAABB")]
	[Token(Token = "0x6000770")]
	public void set_localBounds(Bounds value) { }

	[Address(RVA = "0x3012FF0", Offset = "0x30123F0", Length = "0x42")]
	[Token(Token = "0x6000790")]
	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[Address(RVA = "0x30128C0", Offset = "0x3011CC0", Length = "0xBA")]
	[Token(Token = "0x6000789")]
	public void set_material(Material value) { }

	[Address(RVA = "0x3013120", Offset = "0x3012520", Length = "0x86")]
	[Token(Token = "0x600077C")]
	public void set_receiveShadows(bool value) { }

	[Address(RVA = "0x30130D0", Offset = "0x30124D0", Length = "0x42")]
	[Token(Token = "0x600079B")]
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30131F0", Offset = "0x30125F0", Length = "0x83")]
	[Token(Token = "0x600077B")]
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	[Address(RVA = "0x30131B0", Offset = "0x30125B0", Length = "0x40")]
	[Token(Token = "0x600079A")]
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	[Address(RVA = "0x30128C0", Offset = "0x3011CC0", Length = "0xBA")]
	[Token(Token = "0x600078B")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0x3012790", Offset = "0x3011B90", Length = "0xDE")]
	[Token(Token = "0x600078D")]
	public void set_sharedMaterials(Material[] value) { }

	[Address(RVA = "0x30132D0", Offset = "0x30126D0", Length = "0x86")]
	[Token(Token = "0x600077E")]
	internal void set_smallMeshCulling(bool value) { }

	[Address(RVA = "0x3013280", Offset = "0x3012680", Length = "0x42")]
	[Token(Token = "0x600079D")]
	private static void set_smallMeshCulling_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30133A0", Offset = "0x30127A0", Length = "0x83")]
	[Token(Token = "0x6000781")]
	public void set_sortingLayerID(int value) { }

	[Address(RVA = "0x3013360", Offset = "0x3012760", Length = "0x40")]
	[Token(Token = "0x60007A0")]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3013480", Offset = "0x3012880", Length = "0x1C7")]
	[Token(Token = "0x600077F")]
	public void set_sortingLayerName(string value) { }

	[Address(RVA = "0x3013430", Offset = "0x3012830", Length = "0x42")]
	[Token(Token = "0x600079E")]
	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x3013690", Offset = "0x3012A90", Length = "0x83")]
	[Token(Token = "0x6000783")]
	public void set_sortingOrder(int value) { }

	[Address(RVA = "0x3013650", Offset = "0x3012A50", Length = "0x40")]
	[Token(Token = "0x60007A2")]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30128C0", Offset = "0x3011CC0", Length = "0xBA")]
	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	[Token(Token = "0x6000773")]
	private void SetMaterial(Material m) { }

	[Address(RVA = "0x3012870", Offset = "0x3011C70", Length = "0x42")]
	[Token(Token = "0x6000793")]
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	[Address(RVA = "0x3012790", Offset = "0x3011B90", Length = "0xDE")]
	[Token(Token = "0x6000776")]
	private void SetMaterialArray(Material[] m) { }

	[Address(RVA = "0x30126D0", Offset = "0x3011AD0", Length = "0xB7")]
	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	[Token(Token = "0x6000775")]
	private void SetMaterialArray(Material[] m, int length) { }

	[Address(RVA = "0x3012670", Offset = "0x3011A70", Length = "0x52")]
	[Token(Token = "0x6000795")]
	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

}

