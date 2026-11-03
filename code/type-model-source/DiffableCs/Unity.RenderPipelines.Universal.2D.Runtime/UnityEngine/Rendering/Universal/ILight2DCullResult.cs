namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000033")]
internal interface ILight2DCullResult
{

	[Token(Token = "0x17000041")]
	public List<Light2D> visibleLights
	{
		[Token(Token = "0x600014D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000042")]
	public HashSet<ShadowCasterGroup2D> visibleShadows
	{
		[Token(Token = "0x600014E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600014D")]
	public List<Light2D> get_visibleLights() { }

	[Token(Token = "0x600014E")]
	public HashSet<ShadowCasterGroup2D> get_visibleShadows() { }

	[Token(Token = "0x600014F")]
	public LightStats GetLightStatsByLayer(int layerID, ref LayerBatch layer) { }

	[Token(Token = "0x6000150")]
	public bool IsSceneLit() { }

}

