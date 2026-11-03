using UnityEngine;

// Original art the arcade screens use (Resources/Truxton/ArcadeArt, made by ReconstructionArcadeBuild): the in-game
// HUD glyph font (ui_font01, characters from '!'), the title logo and title backdrop, and the name-entry music.
public sealed class ArcadeArt : ScriptableObject
{
    public Texture2D[] glyphs;
    public Texture2D titleLogo,titleBack;
    public AudioClip nameEntryMusic,titleMusic;
}
