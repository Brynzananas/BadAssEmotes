using BepInEx;
using BepInEx.Configuration;
using EmotesAPI;
using Generics.Dynamics;
using R2API;
using R2API.Utils;
using RiskOfOptions;
using RiskOfOptions.Options;
using RoR2;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace ExamplePlugin
{
    [BepInDependency("com.weliveinasociety.CustomEmotesAPI")]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [R2APISubmoduleDependency("SoundAPI", "PrefabAPI", "CommandHelper", "ResourcesAPI", "NetworkingAPI")]
    public class BadAssEmotesPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.weliveinasociety.badassemotes";
        public const string PluginAuthor = "Nunchuk";
        public const string PluginName = "BadAssEmotes";
        public const string PluginVersion = "1.2.0";
        public void Awake()
        {
            Assets.PopulateAssets();
            Assets.AddSoundBank("nunchukemotes.bnk");
            Assets.AddSoundBank("BadAssEmotes.bnk");
            Assets.LoadSoundBanks();
            AddAnimation("Breakin", "Breakin_", false, true, true);
            AddAnimation("Breakneck", "Breakneck", true, true, true);
            AddAnimation("Crabby", "Crabby", true, true, true);
            AddAnimation("Dabstand", "Dabstand", false, false, false);
            AddAnimation("DanceMoves", "DanceMoves", false, true, false);
            AddAnimation("DanceTherapyIntro", "DanceTherapy", "DanceTherapyLoop", true, true);
            AddAnimation("DeepDab", "Dabstand", false, false, false);
            AddAnimation("Droop", "Droop", true, true, true);
            AddAnimation("ElectroSwing", "ElectroSwing", true, true, true);
            AddAnimation("Extraterrestial", "Extraterestrial", true, true, true);
            AddAnimation("FancyFeet", "FancyFeet", true, true, true);
            AddAnimation("FlamencoIntro", "Flamenco", "FlamencoLoop", true, true);
            AddAnimation("Floss", "Floss", true, true, false);
            AddAnimation("Fresh", "Fresh", true, true, true);
            AddAnimation("Hype", "Hype", true, true, true);
            AddAnimation("Infectious", "Infectious", true, true, true);
            AddAnimation("InfinidabIntro", "Infinidab", "InfinidabLoop", true, false);
            AddAnimation("IntensityIntro", "Intensity", "IntensityLoop", true, true);
            AddAnimation("NeverGonna", "Never_Gonna_Give_you_Up", true, true, true);
            AddAnimation("NinjaStyle", "NinjaStyle", true, true, true);
            AddAnimation("OldSchool", "OldSchool", true, true, true);
            AddAnimation("OrangeJustice", "OrangeJustice", true, true, true);
            AddAnimation("Overdrive", "Overdrive", true, true, true);
            AddAnimation("PawsAndClaws", "Paws_Claws", true, true, true);
            AddAnimation("PhoneItIn", "PhoneItIn", true, true, true);
            AddAnimation("PopLock", "PopLock", true, true, true);
            AddAnimation("Scenario", "Scenario", true, true, true);
            AddAnimation("SpringLoaded", "SpringLoaded", true, false, false);
            AddAnimation("Springy", "Springy", true, true, true);
            AddAnimation("SquatKickIntro", "SquatKick", "SquatKickLoop", true, true);


            //update 1
            AddAnimation("AnkhaZone", "AnkhaZone", true, true, true);
            AddAnimation("GangnamStyle", "GangnamStyle", true, true, true);
            AddAnimation("DontStart", "DontStart", true, true, true);
            AddAnimation("BunnyHop", "BunnyHop", true, true, true);
            AddAnimation("BestMates", "BestMates", true, true, true);
            AddAnimation("JackOPose", "", true, false, false);
            AddAnimation("Crackdown", "Crackdown", true, true, true);
            AddAnimation("Thicc", "Thicc", true, true, true);
            AddAnimation("TakeTheL", "TakeTheL", true, true, true);
            AddAnimation("ArkDance", "ArkDance", true, true, true);
            AddAnimation("LetsDanceBoys", "LetsDanceBoys", true, true, true);
            AddAnimation("BlindingLightsIntro", "BlindingLights", "BlindingLights", true, true);
            AddAnimation("ImDiamond", "ImDiamond", true, true, true);
            AddAnimation("ItsDynamite", "ItsDynamite", true, true, true);
            AddAnimation("TheRobot", "TheRobot", true, true, true);
            AddAnimation("Cartwheelin", "Cartwheelin", true, false, false);
            AddAnimation("CrazyFeet", "CrazyFeet", true, true, true);
            AddAnimation("FullTilt", "FullTilt", true, true, true);
            AddAnimation("FloorSamus", "FloorSamus", true, false, false);
            AddAnimation("DEDEDE", "DEDEDE", true, false, false);
            AddAnimation("Specialist", "Specialist", false, true, true);



            //Update 2
            AddStartAndJoinAnim(new string[] { "PPmusic", "PPmusicFollow" }, "PPmusic", true, true, true);
            AddAnimation("GetDown", "GetDown", false, true, true);
            AddAnimation("Yakuza", "Yakuza", true, true, true);
            AddAnimation("Miku", "Miku", true, true, true);
            AddAnimation("Horny", "Horny", true, true, true);
            AddAnimation("GangTorture", "GangTorture", false, true, true);
            AddAnimation("PoseBurter", "GinyuForce", true, true, true);
            AddAnimation("PoseGinyu", "GinyuForce", true, true, true);
            AddAnimation("PoseGuldo", "GinyuForce", true, true, true);
            AddAnimation("PoseJeice", "GinyuForce", true, true, true);
            AddAnimation("PoseRecoome", "GinyuForce", true, true, true);
            AddStartAndJoinAnim(new string[] { "StoodHere", "StandingHere" }, "StandingHere", true, true, true);
            AddAnimation("Carson", "Carson", false, true, true);
            AddAnimation("Frolic", "Frolic", true, true, true);
            AddAnimation("MoveIt", "MoveIt", true, true, true);
            AddStartAndJoinAnim(new string[] { "ByTheFireLead", "ByTheFirePartner" }, "ByTheFire", true, true, true);
            AddStartAndJoinAnim(new string[] { "SwayLead", "SwayPartner" }, "Sway", true, true, true);
            AddAnimation("Macarena", "Macarena", true, true, true);
            //AddAnimation("Renegade", "Renegade", true, true, true);
            AddAnimation("Thanos", "Thanos", true, true, true);
            AddAnimation("StarGet", "StarGet", false, false, false);
            AddAnimation("Poyo", "Poyo", true, true, true);
            AddAnimation("Hi", "Hi", false, false, false);
            AddAnimation("Chika", "Chika", false, true, true);
            AddAnimation("Goopie", "Goopie", false, true, true);
            AddAnimation("Sad", "Sad", false, true, true);
            AddAnimation("Crossbounce", "Crossbounce", true, true, true);
            AddAnimation("Butt", "Butt", false, false, false);



            //update 3
            AddAnimation("SuperIdol", "SuperIdol", true, true, true);
            AddAnimation("MakeItRainIntro", "MakeItRain", "MakeItRainLoop", true, true);
            AddAnimation("Penguin", "Penguin", true, true, true);
            AddAnimation("DesertRivers", "DesertRivers", false, true, true);
            AddAnimation("HondaStep", "HondaStep", false, true, true);
            AddAnimation("UGotThat", "UGotThat", false, true, true);



            //CustomEmotesAPI.AddCustomAnimation(new AnimationClip[] { Assets.Load<AnimationClip>($"@ExampleEmotePlugin_braindamage:assets/animationreplacements/Standing Here.anim"), Assets.Load<AnimationClip>($"@ExampleEmotePlugin_braindamage:assets/animationreplacements/I Realise.anim") }, true, "Play_StandingHere", "Stop_StandingHere", dimWhenClose: true, syncAnim: true, syncAudio: true, startPref: 0, joinPref: 1);








            CustomEmotesAPI.animChanged += CustomEmotesAPI_animChanged;
        }
        int stand = -1;
        int prop1 = -1;
        CameraTargetParams.CameraParamsOverrideHandle fovHandle;
        internal CharacterBody localBody = null;
        private void CustomEmotesAPI_animChanged(string newAnimation, BoneMapper mapper)
        {
            DebugClass.Log($"----------{newAnimation}");
            if (prop1 != -1)
            {
                prop1 = -1;
            }
            if (newAnimation == "StandingHere")
            {
                stand = mapper.currentClip.syncPos;
            }
            if (stand != -1)
            {
                if (CustomAnimationClip.syncPlayerCount[stand] > 1)
                {
                    AkSoundEngine.SetRTPCValue("MetalGear_Vocals", 1);
                }
                else
                {
                    AkSoundEngine.SetRTPCValue("MetalGear_Vocals", 0);
                }
            }
            if (newAnimation == "Chika")
            {
                prop1 = mapper.props.Count;
                mapper.props.Add(GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/models/desker.prefab")));
                mapper.props[prop1].transform.SetParent(mapper.transform.parent);
                mapper.props[prop1].transform.localEulerAngles = Vector3.zero;
                mapper.props[prop1].transform.localPosition = Vector3.zero;

                if (mapper.local)
                {
                    localBody = NetworkUser.readOnlyLocalPlayersList[0].master?.GetBody();
                    CharacterCameraParamsData data = new CharacterCameraParamsData();
                    data.fov = 70f;
                    data.idealLocalCameraPos = new Vector3(0, 1.5f, -23);
                    if (!fovHandle.isValid)
                    {
                        fovHandle = localBody.GetComponentInChildren<EntityStateMachine>().commonComponents.cameraTargetParams.AddParamsOverride(new CameraTargetParams.CameraParamsOverrideRequest
                        {
                            cameraParamsData = data
                        }, 1f);
                    }
                }
            }
            else
            {
                if (mapper.local && fovHandle.isValid)
                {
                    localBody = NetworkUser.readOnlyLocalPlayersList[0].master?.GetBody();
                    localBody.GetComponentInChildren<EntityStateMachine>().commonComponents.cameraTargetParams.RemoveParamsOverride(fovHandle, 1f);
                    fovHandle = default(CameraTargetParams.CameraParamsOverrideHandle);
                }
            }
            if (newAnimation == "MakeItRainIntro")
            {
                prop1 = mapper.props.Count;
                mapper.props.Add(GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/Prefabs/money.prefab")));
                mapper.props[prop1].transform.SetParent(mapper.transform.parent);
                mapper.props[prop1].transform.localEulerAngles = Vector3.zero;
                mapper.props[prop1].transform.localPosition = Vector3.zero;
            }
            if (newAnimation == "DesertRivers")
            {
                prop1 = mapper.props.Count;
                mapper.props.Add(GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/Prefabs/desertlight.prefab")));
                mapper.props[prop1].transform.SetParent(mapper.transform.parent);
                mapper.props[prop1].transform.localEulerAngles = Vector3.zero;
                mapper.props[prop1].transform.localPosition = Vector3.zero;
            }
            if (newAnimation == "HondaStep")
            {
                prop1 = mapper.props.Count;
                //GameObject myNutz = GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/Prefabs/hondastuff.prefab"));
                //myNutz.GetComponentInChildren<Animation>().playAutomatically = false;
                //myNutz.GetComponentInChildren<Animator>().Play("MusicSync", -1, (CustomAnimationClip.syncTimer[mapper.currentClip.syncPos] % mapper.currentClip.clip[0].length) / mapper.currentClip.clip[0].length);
                //myNutz.GetComponentInChildren<Animation>().Play("MusicSync");
                mapper.props.Add(GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/Prefabs/hondastuff.prefab")));
                mapper.props[prop1].transform.SetParent(mapper.transform.parent);
                mapper.props[prop1].transform.localEulerAngles = Vector3.zero;
                mapper.props[prop1].transform.localPosition = Vector3.zero;
            }
            //if (newAnimation == "Sad")
            //{
            //    prop1 = mapper.props.Count;
            //    mapper.props.Add(GameObject.Instantiate(Assets.Load<GameObject>("@BadAssEmotes_badassemotes:assets/models/trombone.prefab")));
            //    mapper.props[prop1].transform.SetParent(mapper.a2.GetBoneTransform(HumanBodyBones.RightHand));
            //    mapper.props[prop1].transform.localEulerAngles = new Vector3(0, 270, 0);
            //    mapper.props[prop1].transform.localPosition = Vector3.zero;
            //    mapper.props[prop1].transform.localScale = Vector3.one;
            //}
        }

        internal void AddAnimation(string AnimClip, string wwise, bool looping, bool dimAudio, bool sync)
        {
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/badassemotes/{AnimClip}.anim"), looping, $"Play_{wwise}", $"Stop_{wwise}", dimWhenClose: dimAudio, syncAnim: sync, syncAudio: sync);
        }
        internal void AddAnimation(string AnimClip, string wwise, string AnimClip2ElectricBoogaloo, bool dimAudio, bool sync)
        {
            CustomEmotesAPI.AddCustomAnimation(Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/badassemotes/{AnimClip}.anim"), false, $"Play_{wwise}", $"Stop_{wwise}", secondaryAnimation: Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/badassemotes/{AnimClip2ElectricBoogaloo}.anim"), dimWhenClose: dimAudio, syncAnim: sync, syncAudio: sync);
        }
        internal void AddStartAndJoinAnim(string[] AnimClip, string wwise, bool looping, bool dimaudio, bool sync)
        {
            CustomEmotesAPI.AddCustomAnimation(new AnimationClip[] { Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/badassemotes/{AnimClip[0]}.anim"), Assets.Load<AnimationClip>($"@ExampleEmotePlugin_badassemotes:assets/badassemotes/{AnimClip[1]}.anim") }, looping, $"Play_{wwise}", $"Stop_{wwise}", dimWhenClose: dimaudio, syncAnim: sync, syncAudio: sync, startPref: 0, joinPref: 1);
        }
    }


}
