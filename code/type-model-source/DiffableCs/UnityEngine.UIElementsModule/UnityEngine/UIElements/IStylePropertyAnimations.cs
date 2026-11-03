namespace UnityEngine.UIElements;

[Token(Token = "0x2000455")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IStylePropertyAnimations
{

	[Token(Token = "0x170008F6")]
	public int completedAnimationCount
	{
		[Token(Token = "0x6002097")]
		 get { } //Length: 0
		[Token(Token = "0x6002098")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170008F5")]
	public int runningAnimationCount
	{
		[Token(Token = "0x6002095")]
		 get { } //Length: 0
		[Token(Token = "0x6002096")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002094")]
	public void CancelAllAnimations() { }

	[Token(Token = "0x6002093")]
	public void CancelAnimation(StylePropertyId id) { }

	[Token(Token = "0x6002097")]
	public int get_completedAnimationCount() { }

	[Token(Token = "0x6002095")]
	public int get_runningAnimationCount() { }

	[Token(Token = "0x6002092")]
	public void GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	[Token(Token = "0x6002098")]
	public void set_completedAnimationCount(int value) { }

	[Token(Token = "0x6002096")]
	public void set_runningAnimationCount(int value) { }

	[Token(Token = "0x6002090")]
	public bool Start(StylePropertyId id, MaterialDefinition from, MaterialDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208F")]
	public bool Start(StylePropertyId id, List<FilterFunction> from, List<FilterFunction> to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208E")]
	public bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208D")]
	public bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208C")]
	public bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208B")]
	public bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002089")]
	public bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002088")]
	public bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002087")]
	public bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002086")]
	public bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002085")]
	public bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002084")]
	public bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002083")]
	public bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002081")]
	public bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002080")]
	public bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600207F")]
	public bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600208A")]
	public bool Start(StylePropertyId id, Ratio from, Ratio to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600207E")]
	public bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002082")]
	public bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x6002091")]
	public void UpdateAnimation(StylePropertyId id) { }

}

