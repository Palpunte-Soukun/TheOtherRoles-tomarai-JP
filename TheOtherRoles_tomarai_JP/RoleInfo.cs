using HarmonyLib;
using System.Linq;
using System;
using System.Collections.Generic;
using static TheOtherRoles_tomarai_JP.TheOtherRoles_tomarai_JP;
using UnityEngine;

namespace TheOtherRoles_tomarai_JP
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo("ジェスター", Jester.color, "投票で吊られよう", "投票で吊られよう", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("メイヤー", Mayor.color, "投票が2票になっている", "投票が2票になっている", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("ポータルメーカー", Portalmaker.color, "ポータルを作れるぞ！", "ポータルを作れるぞ！", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("エンジニア",  Engineer.color, "船の重要なシステムを管理しよう", "船の重要なシステムを管理しよう", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("シェリフ", Sheriff.color, "<color=#FF1919FF>インポスター</color>を撃ち抜け", "インポスターを撃ち抜け", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("デピュティ", Sheriff.color, "<color=#FF1919FF>インポスター</color>に手錠を掛けよう", "インポスターに手錠を掛けよう", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("ライター", Lighter.color, "あなたの光は永遠に消えない", "あなたの光は永遠に消えない", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("ゴッドファーザー", Godfather.color, "皆殺しにしよう", "皆殺しにしよう", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("マフィオソ", Mafioso.color, "<color=#FF1919FF>マフィア</color>の一員として 皆殺しにしよう", "皆殺しにしよう", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("ジャニター", Janitor.color, "<color=#FF1919FF>マフィア</color>の一員として 死体を掃除しよう", "死体を掃除しよう", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("モーフィング", Morphling.color, "バレないように変身しよう", "変身しよう", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("カモフラージャー", Camouflager.color, "カモフラージュして皆殺しにしよう", "他の人を隠そう", RoleId.Camouflager);
        public static RoleInfo evilHacker = new RoleInfo("イビルハッカー", EvilHacker.color, "システムをハックして皆殺しにしよう", "ハックして皆殺しにしよう", RoleId.EvilHacker);
        public static RoleInfo vampire = new RoleInfo("ヴァンパイア", Vampire.color, "噛んで皆殺しにしよう", "敵を噛もう", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("イレイサー", Eraser.color, "役職を消して皆殺しにしよう", "敵の役職を消そう", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("トリックスター", Trickster.color, "びっくり箱を使って他の人を驚かそう", "敵を驚かそう", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("クリーナー", Cleaner.color, "証拠を消しつつ皆殺しにしよう", "死体を消そう", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("ウォーロック", Warlock.color, "他人を呪ったりして皆殺しにしよう", "呪って皆殺しにしよう", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("バウンティハンター", BountyHunter.color, "ターゲットをキルしよう", "ターゲットをキルしよう", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("ディテクティブ", Detective.color, "足跡で<color=#FF1919FF>インポスター</color>を探し出そう", "足跡を調べよう", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("タイムマスター", TimeMaster.color, "タイムシールドで自分を守ろう", "タイムシールドを使おう", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("メディック", Medic.color, "シールドで他人を守ろう", "他人を守ろう", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("シフター", Shifter.color, "役職を盗ろう", "役職を盗ろう", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("スワッパー", Swapper.color, "票を入れ替えて<color=#FF1919FF>インポスター</color>を吊ろう", "票を入れ替えよう", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("シーア", Seer.color, "あなたは人が死ぬ瞬間を見ることができる", "あなたは人が死ぬ瞬間を見ることができる", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("ハッカー", Hacker.color, "システムをハックして<color=#FF1919FF>インポスター</color>を見つけよう", "ハックしてインポスターを見つけよう", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("トラッカー", Tracker.color, "<color=#FF1919FF>インポスター</color>を突き止めよう", "インポスターを突き止めよう", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("スニッチ", Snitch.color, "タスクを終わらせて<color=#FF1919FF>インポスター</color>を探し出そう", "タスクを終わらせよう", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("ジャッカル", Jackal.color, "クルーと<color=#FF1919FF>インポスター</color>を全員殺して勝利しよう", "全員ぶち殺そう", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("サイドキック", Sidekick.color, "ジャッカルを手助けして皆殺しにしよう", "ジャッカルを手助けして皆殺しにしよう", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("スパイ", Spy.color, "<color=#FF1919FF>インポスター</color>を騙そう", "インポスターを騙そう", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("セキュリティガード", SecurityGuard.color, "ベントを封鎖したり、カメラを置いたりしよう", "ベントを封鎖したり、カメラを置いたりしよう", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("アーソニスト", Arsonist.color, "燃やせ", "燃やせ", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("ナイスゲッサー", Guesser.color, "推理して撃ち抜け", "推理して撃ち抜け", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("イビルゲッサー", Palette.ImpostorRed, "推理して撃ち抜け", "推理して撃ち抜け", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("バルチャー", Vulture.color, "死体を食べて勝利しよう", "死体を食べよう", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("ミーディアム", Medium.color, "死人に質問して情報を手に入れよう", "死人に質問しよう", RoleId.Medium);
        public static RoleInfo madmate = new RoleInfo("マッドメイト", Madmate.color, "<color=#FF1919FF>インポスター</color>の手助けをしよう", "インポスターの手助けをしよう", RoleId.Madmate);
        public static RoleInfo lawyer = new RoleInfo("弁護士", Lawyer.color, "依頼人を守ろう", "依頼人を守ろう", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("追跡者", Pursuer.color, "インポスターのキルをなかったことにしょう", "インポスターのキルをなかったことにしょう", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("インポスター", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "サボを活用して皆殺しにしよう"), "サボを活用して皆殺しにしよう", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("クルー", Color.white, "インポスターを探し出そう", "インポスターを探し出そう", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("ウィッチ", Witch.color, "敵に魔法をかけよう", "敵に魔法をかけよう", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("ニンジャ", Ninja.color, "敵を驚かせて暗殺しよう", "敵を驚かせて暗殺しよう", RoleId.Ninja);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("ブルーディ", Color.yellow, "犯人は血の跡を残していく...", "犯人は血の跡を残していく...", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("アンチテレポート", Color.yellow, "あらゆるテレポートが効かない", "あらゆるテレポートが効かない", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("タイブレイカー", Color.yellow, "同数票で吊り切ろう", "同数票で吊り切ろう", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("ベイト", Color.yellow, "敵を嵌めよう", "敵を嵌めよう", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("サングラス", Color.yellow, "サングラスを手に入れた", "視力が低下している", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("ラバー", Lovers.color, $"恋に落ちてしまった", $"恋に落ちてしまった", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("ミニ", Color.yellow, "成長しきるまで誰にも傷つけられない", "誰も傷つけられない", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "あなたはVIPだ", "あなたが死んだら全員に通知される", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("インバート", Color.yellow, "操作反転状態", "操作が反転している", RoleId.Invert, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            evilHacker,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            crewmate,
            shifter,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            madmate,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
            }

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == EvilHacker.evilHacker) infos.Add(evilHacker);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Madmate.madmate) infos.Add(madmate);
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && PlayerControl.LocalPlayer != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
