// Generates every asset of the StarDrift sample procedurally, then builds the
// players used to test the unity-game-to-project skill.
// Batch entry point: SampleBuilder.BuildAll  (args: -outRoot <dir>)
using System;
using System.Collections.Generic;
using System.IO;
using StarDrift;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SampleBuilder
{
    const string Art = "Assets/Art";
    const string Audio = "Assets/Audio";
    const string Data = "Assets/Data";
    const string Prefabs = "Assets/Prefabs";
    const string Scenes = "Assets/Scenes";
    const string Bonus = "Assets/Bonus";
    const float Ppu = 64f;

    [MenuItem("StarDrift/Generate Content")]
    public static void GenerateContent()
    {
        foreach (var d in new[] { Art, Audio, Data, Prefabs, Scenes, Bonus, "Assets/Meshes", "Assets/Materials", "Assets/StreamingAssets" })
            Directory.CreateDirectory(d);

        // ---------- textures / sprites ----------
        WriteTexture(Art + "/player_ship.png", 64, 64, (x, y) =>
        {
            float cx = Mathf.Abs(x - 31.5f) / 32f, fy = y / 63f;
            bool hull = cx < (1f - fy) * 0.9f && fy > 0.05f;
            bool cockpit = cx < 0.12f && fy > 0.45f && fy < 0.7f;
            if (cockpit) return new Color(0.4f, 0.9f, 1f);
            return hull ? Color.Lerp(new Color(0.3f, 0.4f, 0.9f), Color.white, fy) : Color.clear;
        });
        WriteTexture(Art + "/enemy_saucer.png", 48, 48, (x, y) =>
        {
            float dx = (x - 23.5f) / 24f, dy = (y - 23.5f) / 12f;
            float d = dx * dx + dy * dy;
            float dome = ((x - 23.5f) * (x - 23.5f) + (y - 30f) * (y - 30f)) / 100f;
            if (dome < 1f && y > 28) return new Color(0.7f, 1f, 0.7f, 0.9f);
            return d < 1f ? new Color(1f, 0.3f + 0.4f * (1 - d), 0.3f) : Color.clear;
        });
        WriteTexture(Art + "/bullet.png", 8, 16, (x, y) => Mathf.Abs(x - 3.5f) < 2.5f ? new Color(1f, 1f, 0.5f) : Color.clear);
        var rng = new System.Random(1234);
        var stars = new HashSet<int>();
        for (int i = 0; i < 90; i++) stars.Add(rng.Next(256 * 256));
        WriteTexture(Art + "/starfield.png", 256, 256, (x, y) => stars.Contains(y * 256 + x) ? Color.white : new Color(0.02f, 0.02f, 0.08f));
        WriteTexture(Art + "/title_logo.png", 256, 64, (x, y) =>
        {
            bool band = (y / 8) % 2 == 0 && x > 8 && x < 248 && y > 8 && y < 56;
            return band ? Color.Lerp(new Color(1f, 0.5f, 0.1f), new Color(1f, 0.9f, 0.3f), y / 64f) : Color.clear;
        });
        // 4-frame explosion sheet (128x32) -> Multiple sprite mode
        WriteTexture(Art + "/explosion_sheet.png", 128, 32, (x, y) =>
        {
            int frame = x / 32;
            float r = Mathf.Sqrt((x % 32 - 15.5f) * (x % 32 - 15.5f) + (y - 15.5f) * (y - 15.5f));
            float radius = 5f + frame * 3.5f;
            return r < radius ? Color.Lerp(Color.yellow, new Color(1f, 0.2f, 0f, 0.5f), r / radius) : Color.clear;
        });
        WriteTexture("Assets/Materials/planet_surface.png", 128, 64, (x, y) =>
        {
            float n = Mathf.PerlinNoise(x * 0.08f, y * 0.12f);
            return Color.Lerp(new Color(0.2f, 0.3f, 0.7f), new Color(0.3f, 0.7f, 0.4f), n > 0.5f ? 1f : 0f);
        });
        WriteTexture(Bonus + "/bonus_star.png", 32, 32, (x, y) =>
        {
            float dx = x - 15.5f, dy = y - 15.5f;
            float a = Mathf.Atan2(dy, dx), r = Mathf.Sqrt(dx * dx + dy * dy);
            float edge = 9f + 6f * Mathf.Cos(a * 5f);
            return r < edge ? new Color(1f, 0.85f, 0.2f) : Color.clear;
        });
        AssetDatabase.Refresh();
        ConfigureSprite(Art + "/player_ship.png", null);
        ConfigureSprite(Art + "/enemy_saucer.png", null);
        ConfigureSprite(Art + "/bullet.png", null);
        ConfigureSprite(Art + "/starfield.png", null, 25.6f);
        ConfigureSprite(Art + "/title_logo.png", null);
        ConfigureSprite(Art + "/explosion_sheet.png", new[] { new Rect(0, 0, 32, 32), new Rect(32, 0, 32, 32), new Rect(64, 0, 32, 32), new Rect(96, 0, 32, 32) });
        ConfigureSprite(Bonus + "/bonus_star.png", null);

        // ---------- audio ----------
        WriteWav(Audio + "/sfx_shoot.wav", 0.08f, t => Mathf.Sin(2 * Mathf.PI * Mathf.Lerp(1400, 600, t / 0.08f) * t) * (1 - t / 0.08f));
        var noise = new System.Random(7);
        WriteWav(Audio + "/sfx_explode.wav", 0.35f, t => (float)(noise.NextDouble() * 2 - 1) * Mathf.Pow(1 - t / 0.35f, 2));
        float[] notes = { 220f, 277.18f, 329.63f, 440f, 329.63f, 277.18f };
        WriteWav(Audio + "/bgm_loop.wav", 3f, t =>
        {
            float f = notes[(int)(t * 4) % notes.Length];
            return 0.25f * Mathf.Sign(Mathf.Sin(2 * Mathf.PI * f * t)) * (1 - (t * 4 % 1f) * 0.7f);
        });
        AssetDatabase.Refresh();

        // ---------- text / mesh / material ----------
        File.WriteAllText(Data + "/level_info.json", "{\"title\":\"STAR DRIFT\",\"subtitle\":\"Sample for the rebuild pipeline\",\"targetScore\":5000}");
        AssetDatabase.ImportAsset(Data + "/level_info.json");
        var mesh = BuildSphere(16, 24);
        AssetDatabase.CreateAsset(mesh, "Assets/Meshes/Planet.asset");
        var mat = new Material(Shader.Find("Standard")) { name = "Planet" };
        mat.mainTexture = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Materials/planet_surface.png");
        mat.color = new Color(0.9f, 0.95f, 1f);
        mat.SetFloat("_Glossiness", 0.2f);
        AssetDatabase.CreateAsset(mat, "Assets/Materials/Planet.mat");

        // ---------- prefabs ----------
        var bulletPrefab = SavePrefab(Prefabs + "/Bullet.prefab", () =>
        {
            var go = NewSprite("Bullet", Art + "/bullet.png", 5);
            Trigger2D(go, circle: 0.1f);
            go.AddComponent<Bullet>().speed = 14f;
            return go;
        });
        var enemyPrefab = SavePrefab(Prefabs + "/Enemy.prefab", () =>
        {
            var go = NewSprite("Enemy", Art + "/enemy_saucer.png", 2);
            Trigger2D(go, box: new Vector2(0.7f, 0.5f));
            var e = go.AddComponent<Enemy>();
            e.hp = 2; e.score = 100;
            return go;
        });
        var explosionPrefab = SavePrefab(Prefabs + "/Explosion.prefab", () =>
        {
            var frames = AllSprites(Art + "/explosion_sheet.png");
            var go = NewSprite("Explosion", null, 8);
            go.GetComponent<SpriteRenderer>().sprite = frames[0];
            var fb = go.AddComponent<SpriteFlipbook>();
            fb.frames = frames; fb.fps = 14f;
            return go;
        });
        var bonusPrefab = SavePrefab(Bonus + "/BonusPickup.prefab", () =>
        {
            var go = NewSprite("BonusPickup", Bonus + "/bonus_star.png", 4);
            Trigger2D(go, circle: 0.35f);
            go.AddComponent<Pickup>().value = 500;
            var glow = NewSprite("Glow", Bonus + "/bonus_star.png", 3);
            glow.transform.SetParent(go.transform, false);
            glow.transform.localScale = Vector3.one * 1.5f;
            glow.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.4f);
            return go;
        });

        // ---------- scriptable objects ----------
        var waveA = ScriptableObject.CreateInstance<EnemyWave>();
        waveA.waveName = "Opening Line"; waveA.count = 6; waveA.interval = 0.4f; waveA.speed = 2.5f;
        waveA.tint = new Color(1f, 0.6f, 0.6f); waveA.pattern = WavePattern.Line; waveA.enemyPrefab = enemyPrefab;
        waveA.spawnPoints = new[] { new Vector2(-5, 6), new Vector2(-3, 6), new Vector2(-1, 6), new Vector2(1, 6), new Vector2(3, 6), new Vector2(5, 6) };
        AssetDatabase.CreateAsset(waveA, Data + "/Wave_A.asset");
        var waveB = ScriptableObject.CreateInstance<EnemyWave>();
        waveB.waveName = "Sine Swarm"; waveB.count = 5; waveB.interval = 0.6f; waveB.speed = 2f;
        waveB.tint = new Color(0.6f, 1f, 0.7f); waveB.pattern = WavePattern.Sine; waveB.enemyPrefab = enemyPrefab;
        waveB.spawnPoints = new Vector2[0];
        AssetDatabase.CreateAsset(waveB, Data + "/Wave_B.asset");

        // ---------- scenes ----------
        var title = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        NewCamera();
        var logo = NewSprite("Logo", Art + "/title_logo.png", 0);
        logo.transform.position = new Vector3(0, 1, 0);
        logo.transform.localScale = new Vector3(2, 2, 1);
        new GameObject("Title").AddComponent<TitleScreen>();
        EditorSceneManager.SaveScene(title, Scenes + "/Title.unity");

        var main = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        NewCamera();
        var lightGo = new GameObject("Directional Light");
        var light = lightGo.AddComponent<Light>();
        light.type = LightType.Directional; light.intensity = 1.1f; light.color = new Color(1f, 0.96f, 0.9f);
        lightGo.transform.rotation = Quaternion.Euler(50, -30, 0);

        var bg = new GameObject("Background").AddComponent<ScrollingBackground>();
        bg.speed = 1.2f; bg.tileHeight = 10f;
        var tiles = new Transform[2];
        for (int i = 0; i < 2; i++)
        {
            var t = NewSprite("Tile" + i, Art + "/starfield.png", -10);
            t.transform.SetParent(bg.transform, false);
            t.transform.localPosition = new Vector3(0, i * 10f, 1f);
            t.transform.localScale = new Vector3(2f, 1f, 1f);
            tiles[i] = t.transform;
        }
        bg.tiles = tiles;

        var planet = new GameObject("Planet");
        planet.AddComponent<MeshFilter>().sharedMesh = mesh;
        planet.AddComponent<MeshRenderer>().sharedMaterial = mat;
        planet.AddComponent<Spinner>();
        planet.transform.position = new Vector3(5f, 2.5f, 5f);
        planet.transform.localScale = Vector3.one * 2.5f;

        var player = NewSprite("Player", Art + "/player_ship.png", 5);
        player.transform.position = new Vector3(0, -3.5f, 0);
        Trigger2D(player, circle: 0.3f);
        player.AddComponent<AudioSource>().playOnAwake = false;
        var ship = player.AddComponent<PlayerShip>();
        ship.bulletPrefab = bulletPrefab;
        ship.shootSfx = AssetDatabase.LoadAssetAtPath<AudioClip>(Audio + "/sfx_shoot.wav");

        var gmGo = new GameObject("GameManager");
        var music = gmGo.AddComponent<AudioSource>();
        music.clip = AssetDatabase.LoadAssetAtPath<AudioClip>(Audio + "/bgm_loop.wav");
        music.loop = true; music.playOnAwake = true; music.volume = 0.4f;
        var gm = gmGo.AddComponent<GameManager>();
        gm.levelInfoJson = AssetDatabase.LoadAssetAtPath<TextAsset>(Data + "/level_info.json");
        gm.explodeSfx = AssetDatabase.LoadAssetAtPath<AudioClip>(Audio + "/sfx_explode.wav");
        gm.explosionPrefab = explosionPrefab;

        var spawner = new GameObject("Spawner").AddComponent<EnemySpawner>();
        spawner.waves = new[] { waveA, waveB };
        new GameObject("BonusLoader").AddComponent<BundleLoader>();
        EditorSceneManager.SaveScene(main, Scenes + "/Main.unity");

        EditorBuildSettings.scenes = new[]
        {
            new EditorBuildSettingsScene(Scenes + "/Title.unity", true),
            new EditorBuildSettingsScene(Scenes + "/Main.unity", true),
        };

        // ---------- encrypted bonus bundle ----------
        AssetImporter.GetAtPath(Bonus + "/BonusPickup.prefab").assetBundleName = "bonus";
        AssetDatabase.SaveAssets();
        Directory.CreateDirectory("Temp/Bundles");
        BuildPipeline.BuildAssetBundles("Temp/Bundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
        var plain = File.ReadAllBytes("Temp/Bundles/bonus");
        var key = System.Text.Encoding.ASCII.GetBytes("StarDrift#Key!07");
        var enc = new byte[32 + plain.Length];
        var hdr = new System.Random(99);
        hdr.NextBytes(enc);
        enc[0] = (byte)'S'; enc[1] = (byte)'D'; enc[2] = (byte)'P'; enc[3] = (byte)'K';
        for (int i = 0; i < plain.Length; i++) enc[32 + i] = (byte)(plain[i] ^ key[i % key.Length]);
        File.WriteAllBytes("Assets/StreamingAssets/bonus.dat", enc);
        AssetDatabase.Refresh();
        Debug.Log("StarDrift content generated");
    }

    public static void BuildAll()
    {
        var outRoot = Arg("-outRoot") ?? Path.GetFullPath("../builds");
        GenerateContent();

        PlayerSettings.companyName = "RebuildLab";
        PlayerSettings.productName = "StarDrift";
        PlayerSettings.fullScreenMode = FullScreenMode.Windowed;
        PlayerSettings.defaultScreenWidth = 960;
        PlayerSettings.defaultScreenHeight = 540;
        PlayerSettings.runInBackground = true;
        PlayerSettings.usePlayerLog = true;
        PlayerSettings.SetScriptingBackend(UnityEditor.Build.NamedBuildTarget.Standalone, ScriptingImplementation.Mono2x);

        Build(Path.Combine(outRoot, "StarDrift_Mono", "StarDrift.exe"), BuildOptions.None);
        Build(Path.Combine(outRoot, "StarDrift_MonoLZ4", "StarDrift.exe"), BuildOptions.CompressWithLz4HC);
    }

    static void Build(string path, BuildOptions options)
    {
        var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = new[] { Scenes + "/Title.unity", Scenes + "/Main.unity" },
            locationPathName = path,
            target = BuildTarget.StandaloneWindows64,
            options = options,
        });
        Debug.Log($"BUILD {path}: {report.summary.result} ({report.summary.totalErrors} errors)");
        if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded) EditorApplication.Exit(1);
    }

    // ---------------------------------------------------------------- helpers
    static string Arg(string name)
    {
        var a = Environment.GetCommandLineArgs();
        for (int i = 0; i < a.Length - 1; i++) if (a[i] == name) return a[i + 1];
        return null;
    }

    static void WriteTexture(string path, int w, int h, Func<int, int, Color> px)
    {
        var tex = new Texture2D(w, h, TextureFormat.RGBA32, false);
        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++) tex.SetPixel(x, y, px(x, y));
        File.WriteAllBytes(path, tex.EncodeToPNG());
        UnityEngine.Object.DestroyImmediate(tex);
    }

#pragma warning disable 618
    static void ConfigureSprite(string path, Rect[] slices, float ppu = Ppu)
    {
        var ti = (TextureImporter)AssetImporter.GetAtPath(path);
        ti.textureType = TextureImporterType.Sprite;
        ti.spritePixelsPerUnit = ppu;
        ti.filterMode = FilterMode.Point;
        ti.textureCompression = TextureImporterCompression.Uncompressed;
        ti.alphaIsTransparency = true;
        if (slices != null)
        {
            ti.spriteImportMode = SpriteImportMode.Multiple;
            var name = Path.GetFileNameWithoutExtension(path);
            var metas = new SpriteMetaData[slices.Length];
            for (int i = 0; i < slices.Length; i++)
                metas[i] = new SpriteMetaData { name = name + "_" + i, rect = slices[i], alignment = (int)SpriteAlignment.Center, pivot = new Vector2(0.5f, 0.5f) };
            ti.spritesheet = metas;
        }
        else ti.spriteImportMode = SpriteImportMode.Single;
        ti.SaveAndReimport();
    }
#pragma warning restore 618

    static Sprite[] AllSprites(string path)
    {
        var list = new List<Sprite>();
        foreach (var o in AssetDatabase.LoadAllAssetsAtPath(path)) if (o is Sprite s) list.Add(s);
        list.Sort((a, b) => string.CompareOrdinal(a.name, b.name));
        return list.ToArray();
    }

    static void WriteWav(string path, float seconds, Func<float, float> sample)
    {
        const int rate = 44100;
        int n = (int)(rate * seconds);
        using (var bw = new BinaryWriter(File.Create(path)))
        {
            bw.Write(System.Text.Encoding.ASCII.GetBytes("RIFF")); bw.Write(36 + n * 2);
            bw.Write(System.Text.Encoding.ASCII.GetBytes("WAVEfmt ")); bw.Write(16); bw.Write((short)1); bw.Write((short)1);
            bw.Write(rate); bw.Write(rate * 2); bw.Write((short)2); bw.Write((short)16);
            bw.Write(System.Text.Encoding.ASCII.GetBytes("data")); bw.Write(n * 2);
            for (int i = 0; i < n; i++) bw.Write((short)(Mathf.Clamp(sample(i / (float)rate), -1f, 1f) * 32000));
        }
    }

    static Mesh BuildSphere(int rings, int segments)
    {
        var v = new List<Vector3>(); var nrm = new List<Vector3>(); var uv = new List<Vector2>(); var tri = new List<int>();
        for (int r = 0; r <= rings; r++)
            for (int s = 0; s <= segments; s++)
            {
                float th = Mathf.PI * r / rings, ph = 2 * Mathf.PI * s / segments;
                var p = new Vector3(Mathf.Sin(th) * Mathf.Cos(ph), Mathf.Cos(th), Mathf.Sin(th) * Mathf.Sin(ph)) * 0.5f;
                v.Add(p); nrm.Add(p.normalized); uv.Add(new Vector2(s / (float)segments, 1 - r / (float)rings));
            }
        for (int r = 0; r < rings; r++)
            for (int s = 0; s < segments; s++)
            {
                int a = r * (segments + 1) + s, b = a + segments + 1;
                tri.AddRange(new[] { a, a + 1, b, b, a + 1, b + 1 });
            }
        var m = new Mesh { name = "Planet" };
        m.SetVertices(v); m.SetNormals(nrm); m.SetUVs(0, uv); m.SetTriangles(tri, 0);
        m.RecalculateBounds();
        return m;
    }

    static GameObject NewSprite(string name, string texPath, int order)
    {
        var go = new GameObject(name);
        var sr = go.AddComponent<SpriteRenderer>();
        if (texPath != null) sr.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(texPath);
        sr.sortingOrder = order;
        return go;
    }

    static void Trigger2D(GameObject go, float circle = 0f, Vector2 box = default)
    {
        var rb = go.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.useFullKinematicContacts = true;
        if (circle > 0) { var c = go.AddComponent<CircleCollider2D>(); c.radius = circle; c.isTrigger = true; }
        else { var b = go.AddComponent<BoxCollider2D>(); b.size = box; b.isTrigger = true; }
    }

    static GameObject SavePrefab(string path, Func<GameObject> make)
    {
        var go = make();
        var prefab = PrefabUtility.SaveAsPrefabAsset(go, path);
        UnityEngine.Object.DestroyImmediate(go);
        return prefab;
    }

    static void NewCamera()
    {
        var go = new GameObject("Main Camera") { tag = "MainCamera" };
        var cam = go.AddComponent<Camera>();
        cam.orthographic = true; cam.orthographicSize = 5f;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(0.02f, 0.02f, 0.08f);
        go.AddComponent<AudioListener>();
        go.transform.position = new Vector3(0, 0, -10);
    }
}
