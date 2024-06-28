using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace HsMod
{
    public static class PluginConfig
    {
        public static ConfigEntry<bool> isPluginEnable;
        public static ConfigEntry<bool> isFakeOpenEnable;
        public static ConfigEntry<Utils.ConfigTemplate> configTemplate;
        public static ConfigEntry<bool> isTimeGearEnable;
        public static ConfigEntry<bool> isShortcutsEnable;
        public static ConfigEntry<int> targetFrameRate;
        public static ConfigEntry<bool> isDynamicFpsEnable;

        public static ConfigEntry<int> timeGear;
        public static ConfigEntry<int> receiveEnemyEmoteLimit;

        public static ConfigEntry<bool> isIGMMessageShow;
        public static ConfigEntry<bool> isOnApplicationFocus;
        public static ConfigEntry<bool> isAutoExit;
        //public static ConfigEntry<bool> isAutoRestart;
        public static ConfigEntry<bool> isAlertPopupShow;
        public static ConfigEntry<Utils.AlertPopupResponse> responseAlertPopup;
        public static ConfigEntry<bool> isRewardToastShow;
        public static ConfigEntry<bool> isAutoOpenBoxesRewardEnable;
        public static ConfigEntry<bool> isFullnameShow;
        public static ConfigEntry<bool> isOpponentRankInGameShow;
        public static ConfigEntry<bool> isSkipHeroIntro;
        public static ConfigEntry<bool> isThinkEmotesEnable;
        public static ConfigEntry<bool> isExtendedBMEnable;
        public static ConfigEntry<bool> isQuickPackOpeningEnable;
        public static ConfigEntry<bool> isAutoPackOpeningEnable;
        public static ConfigEntry<bool> isShowCardLargeCount;
        public static ConfigEntry<bool> isAutoRefundCardDisenchantEnable;
        public static ConfigEntry<bool> isShowCollectionCardIdEnable;
        public static ConfigEntry<bool> isShowRetireForever;
        public static ConfigEntry<bool> isIdleKickEnable;
        public static ConfigEntry<bool> isBypassDeckShareCodeCheckEnable;

        //public static ConfigEntry<Utils.QuickMode> quickModeState;
        public static ConfigEntry<bool> isQuickModeEnable;
        public static ConfigEntry<bool> isCardTrackerEnable;
        public static ConfigEntry<bool> isCardRevealedEnable;
        public static ConfigEntry<bool> isMoveEnemyCardsEnable;
        public static ConfigEntry<bool> isAutoReportEnable;

        public static ConfigEntry<bool> isAutoRecvMercenaryRewardEnable;
        public static ConfigEntry<bool> isMercenaryBattleZoom;
        public static ConfigEntry<Utils.CardState> mercenaryDiamondCardState;
        public static ConfigEntry<Utils.CardState> randomMercenarySkinEnable;

        public static ConfigEntry<bool> isShutUpBobEnable;
        public static ConfigEntry<bool> isBgsGoldenEnable;

        public static ConfigEntry<bool> isOpponentGoldenCardShow;
        public static ConfigEntry<bool> isSignatureCardStateEnable;
        public static ConfigEntry<Utils.CardState> goldenCardState;
        public static ConfigEntry<Utils.CardState> maxCardState;

        public static ConfigEntry<KeyboardShortcut> keyTimeGearUp;
        public static ConfigEntry<KeyboardShortcut> keyTimeGearDown;
        public static ConfigEntry<KeyboardShortcut> keyTimeGearDefault;
        public static ConfigEntry<KeyboardShortcut> keyTimeGearMax;
        public static ConfigEntry<KeyboardShortcut> keySimulateDisconnect;
        public static ConfigEntry<KeyboardShortcut> keyCopyBattleTag;
        public static ConfigEntry<KeyboardShortcut> keyCopySelectBattleTag;
        public static ConfigEntry<KeyboardShortcut> keyConcede;
        public static ConfigEntry<KeyboardShortcut> keyContinueMulligan;
        public static ConfigEntry<KeyboardShortcut> keySquelch;
        public static ConfigEntry<KeyboardShortcut> keySoundMute;
        public static ConfigEntry<KeyboardShortcut> keyShutUpBob;
        public static ConfigEntry<KeyboardShortcut> keyRefund;
        public static ConfigEntry<KeyboardShortcut> keyReadNewCards;
        //public static ConfigEntry<KeyboardShortcut> keyRuin;    //毁灭吧赶紧的
        public static ConfigEntry<KeyboardShortcut> keyShowFPS;

        public static ConfigEntry<KeyboardShortcut> keyEmoteGreetings;
        public static ConfigEntry<KeyboardShortcut> keyEmoteWellPlayed;
        public static ConfigEntry<KeyboardShortcut> keyEmoteThanks;
        public static ConfigEntry<KeyboardShortcut> keyEmoteWow;
        public static ConfigEntry<KeyboardShortcut> keyEmoteOops;
        public static ConfigEntry<KeyboardShortcut> keyEmoteThreaten;

        public static ConfigEntry<int> skinCoin;
        public static ConfigEntry<int> skinCardBack;
        public static ConfigEntry<int> skinBoard;
        public static ConfigEntry<int> skinBgsBoard;
        public static ConfigEntry<int> skinBgsFinisher;
        public static ConfigEntry<int> skinBob;
        public static ConfigEntry<int> skinHero;
        public static ConfigEntry<int> skinOpposingHero;
        public static ConfigEntry<bool> isSkinDefalutHeroEnable;

        public static ConfigEntry<bool> isShowFPSEnable;
        public static ConfigEntry<bool> isInternalModeEnable;
        public static ConfigEntry<int> webServerPort;
        public static ConfigEntry<string> webPageBackImg;
        public static ConfigEntry<bool> isWebshellEnable;

        public static ConfigEntry<string> hsMatchLogPath;
        public static ConfigEntry<string> hsLogPath;
        public static ConfigEntry<long> autoQuitTimer;    // 定时退出

        public static ConfigEntry<Utils.DevicePreset> fakeDevicePreset;
        public static ConfigEntry<OSCategory> fakeDeviceOs;
        public static ConfigEntry<ScreenCategory> fakeDeviceScreen;
        public static ConfigEntry<string> fakeDeviceName;

        public static ConfigEntry<int> fakePackCount;
        public static ConfigEntry<BoosterDbId> fakeBoosterDbId;
        public static ConfigEntry<bool> isFakeRandomResult;
        public static ConfigEntry<bool> isFakeRandomRarity;
        public static ConfigEntry<bool> isFakeRandomPremium;
        public static ConfigEntry<bool> isFakeAtypicalRandomPremium;
        public static ConfigEntry<TAG_PREMIUM> fakeRandomPremium;
        public static ConfigEntry<Utils.CardRarity> fakeRandomRarity;
        public static ConfigEntry<int> fakeCatchupCount;
        public static ConfigEntry<int> fakeCardID1;
        public static ConfigEntry<TAG_PREMIUM> fakeCardPremium1;
        public static ConfigEntry<int> fakeCardID2;
        public static ConfigEntry<TAG_PREMIUM> fakeCardPremium2;
        public static ConfigEntry<int> fakeCardID3;
        public static ConfigEntry<TAG_PREMIUM> fakeCardPremium3;
        public static ConfigEntry<int> fakeCardID4;
        public static ConfigEntry<TAG_PREMIUM> fakeCardPremium4;
        public static ConfigEntry<int> fakeCardID5;
        public static ConfigEntry<TAG_PREMIUM> fakeCardPremium5;


        public static ConfigEntry<Utils.BuyAdventureTemplate> buyAdventure;
        public static ConfigEntry<bool> isKarazhanFixEnable;
        public static ShowFPS showFPS;
        public static Dictionary<int, int> HeroesMapping = new Dictionary<int, int>();
        public static Dictionary<string, string> HeroesPowerMapping = new Dictionary<string, string>();


        public static class CommandConfig
        {
            public static int webServerPort = -1;
            public static string hsMatchLogPath = "";
            public static int width = -1;
            public static int height = -1;
        }

        public static long timeKeeper = DateTime.Now.Ticks;

        public static List<Utils.CardMapping> CardsMapping = new List<Utils.CardMapping>();    //卡片替换映射，目前暂未使用
        public static IGraphicsManager graphicsManager;
        public static void ConfigBind(ConfigFile config)
        {
            config.Clear();
            isPluginEnable = config.Bind("Общие", "Активация HsMod", false, "Включение плагина (для применения изменений требуется перезагрузить игру)");
            configTemplate = config.Bind("Общие", "Шаблон", Utils.ConfigTemplate.DoNothing, "Настройка шаблон выполнения так, чтобы не изменять конфигурацию, если выбран вариант DoNothing. При сохранении настроек автоматически заменяется на DoNothing.");
            isShortcutsEnable = config.Bind("Общие", "Состояние горячих клавиш", false, "Активация горячих клавиш");
            isTimeGearEnable = config.Bind("Общие", "Состояние скорости игры", false, "Активация изменения скорости игры");
            timeGear = config.Bind("Общие", "Множитель скорости игры", 0, new ConfigDescription("Изменение скорости игры, 1 и 0 одинаковы, отрицательные числа замедление, положительные ускорение", new AcceptableValueRange<int>(-32, 32)));
            isShowFPSEnable = config.Bind("Общие", "Счётчик FPS", false, "Отображение счётчика FPS (левый Ctrl+P)");
            targetFrameRate = config.Bind("Общие", "Блокировка FPS", -1, new ConfigDescription("Блокировка FPS, -1 - 30 FPS", new AcceptableValueRange<int>(-1, 2333)));

            isIGMMessageShow = config.Bind("Оптимизация", "Игровые сообщения", true, "(Если вы не можете открыть магазин карт, попробуй те включить это) Отображение игровых сообщений (рекламные сообщения, исправления, информация о таблице лидеров и т. д.)");
            isAlertPopupShow = config.Bind("Оптимизация", "Всплыващие сообщения", true, "Показ вспылывающих сообщений");
            responseAlertPopup = config.Bind("Оптимизация", "Реакция на всплывающие сообщения", Utils.AlertPopupResponse.DONOTHING, "Как реагировать на всплывающие уведомления при блокировке всплывающих сообщений");
            isOnApplicationFocus = config.Bind("Оптимизация", "Фокус приложения", true, "isOnApplicationFocus");
            isRewardToastShow = config.Bind("Оптимизация", "Окно наград", true, "Отображение игровых заданий, наград за достижения, советы по улучшению и т. д. (при получении наград маркеры могут отсутствовать)");
            isAutoOpenBoxesRewardEnable = config.Bind("Оптимизация", "Автоматическое открытие наград", false, "Автоматическое открытие сундуков арены (дуэли, наемники и т. д.)");
            isAutoExit = config.Bind("Оптимизация", "Автоматический выход", false, "Автоматически завершать работу при возникновении ошибки");
            //isAutoRestart = config.Bind("优化", "退出时重启", false, "（可能无效）遇到错误是否自动重启");
            isShowCardLargeCount = config.Bind("Оптимизация", "Количество карт в коллекции", false, "Отображаемое количество карт в коллекции, если их число больше или равно 10 (временная ошибка при выборе)");
            isShowCollectionCardIdEnable = config.Bind("Оптимизация", "Показ ID карты в коллекции", false, "Отображение и копирование CardID выбранной карты при щелчке правой кнопкой мыши на карту (скин)");
            isBypassDeckShareCodeCheckEnable = config.Bind("Оптимизация", "Код шеринга колоды", false, "Обнаружение кода шеринга колоды");
            isShowRetireForever = config.Bind("Оптимизация", "Сдача сетов", false, "Сдача сетов при счёте 0-0");
            isIdleKickEnable = config.Bind("Оптимизация", "Бездействие", true, "(Пока не тестировалось) Разрешить длительные периоды бездействия (конфигурация не загружается при запуске игры)");


            isQuickPackOpeningEnable = config.Bind("Паки", "Ускоренное открытие паков", false, "Ускоренное открытие паков, прямое отображение результатов при использовании пространства для открытия пакетов");
            isAutoPackOpeningEnable = config.Bind("Паки", "Автоматическое открытие паков", false, "(Используйте с осторожностью, есть ошибки!) Открывайте все паки карт, не различайте категории паки карт (основано на ускорении открытия паков)");
            isAutoRefundCardDisenchantEnable = config.Bind("Паки", "Уничтожение карт", false, "Автоматическое уничтожение полных антипылевых карты при открытии паков");

            isAutoReportEnable = config.Bind("Игроки", "Авто репорт", false, "Автоматическая отправка репортов о нарушениях соперников, читерстве и скриптинге, а также о злонамеренных сдачах в конце игры");
            // isAutoReportEnable = config.Bind("好友", "自动举报", true, new ConfigDescription("对局结束后自动举报对手昵称违规、作弊和脚本、恶意投降", null, new object[] { "Advanced" }));
            isMoveEnemyCardsEnable = config.Bind("Игроки", "Карточки зрителей", false, "(Не проверено) Показывать карты из руки противника в режиме зрителя");


            isQuickModeEnable = config.Bind("Хартстоун", "Быстрый бой ИИ", false, "Включение режима быстрого боя ИИ таверны или наемников");
            isFullnameShow = config.Bind("Хартстоун", "Показ полного имени", false, "Показ полного имени баттлнета противника; если эта опция включена, она также позволит добавить текущего противника (и когда ярлык активирован, он также позволит добавить противника).");
            isOpponentRankInGameShow = config.Bind("Хартстоун", "Показ уровней ладдера", false, "Отображать уровень ладдера противника перед легендой");
            isCardTrackerEnable = config.Bind("Хартстоун", "Отслеживание карт", false, "Предполагать карты соперника и давать подсказки (например, выбор и т.д., с вероятностью ошибочного определения)");
            isCardRevealedEnable = config.Bind("Хартстоун", "Раскрытие карт", false, "Отображение известных карт (с вероятностью того, что Hearthstone автоматически отключится и переподключится)");
            isSkipHeroIntro = config.Bind("Хартстоун", "Пропуск показа героев", false, "Пропуск представление геров (должен пропускать муллиган)");
            isExtendedBMEnable = config.Bind("Хартстоун", "Смайлики с минимальной задержкой", false, "Неограниченное количество смайликов (минимальная задержка 1,5 с)");
            isThinkEmotesEnable = config.Bind("Хартстоун", "Отображение смайликов", true, "Отображение смайликов в игре");
            receiveEnemyEmoteLimit = config.Bind("Хартстоун", "Число смайликов", -1, new ConfigDescription("Количество внутриигровых смайликов ограничено, большое количество автоматически блокирует смайлики противника, 0 при открытии щита, -1 не ограничено (есть небольшие ошибки)", new AcceptableValueRange<int>(-1, 100)));
            isOpponentGoldenCardShow = config.Bind("Хартстоун", "Эффекты карт противника", true, "Отображение эффектов карт противника (отменяет ВСЕ конфигурации)");
            isSignatureCardStateEnable = config.Bind("Хартстоун", "Отображение анаглифов", true, "Показы анаглифов самых высоких эффектов карты (влияет только на самые высокие эффекты карты)");
            goldenCardState = config.Bind("Хартстоун", "Эффекты золотых карт", Utils.CardState.Default, "Обязательные эффекты золотых карт");
            maxCardState = config.Bind("Хартстоун", "Максимальные эффекты карт", Utils.CardState.Default, "Заставить карты иметь самые высокие FX-эффекты (текущий приоритет: Diamond, Isoprint, Gold, Normal).");

            isAutoRecvMercenaryRewardEnable = config.Bind("Наёмники", "Автоматическое получение наград", false, "Автоматическое получение наград за наемников (сундуки с сокровищами)");
            isMercenaryBattleZoom = config.Bind("Наёмники", "Масштабирование", true, "(Возможная ошибка) Разрешать наемникам приближать и отдалять экран во время боя.");
            mercenaryDiamondCardState = config.Bind("Наёмники", "Замена алмазного скина", Utils.CardState.Default, "Если возможно, заменить его на алмазный скин (менее приоритетный, чем Hearthstone-Card Max FX).");
            randomMercenarySkinEnable = config.Bind("Наёмники", "Случайные скины", Utils.CardState.Default, "Случайные скины (алмазные скины не включены, а значение эффекта карты Hearthstone-Diamond не может быть ОТКЛЮЧЕНО)");

            isShutUpBobEnable = config.Bind("Таверна", "Тихий Боб", false, "Отключение реплик Боба");
            isBgsGoldenEnable = config.Bind("Таверна", "Золочение таверны", false, "(Тестирование, требуется, чтобы эффекты золотых карт были включены в Hearthstone Card Effects) Золочение таверны. Это золочение не позолотит вложения и квестовые линии.");
            //考虑导出单独配置
            skinCoin = config.Bind("Скины", "硬币", -1, "幸运币的偏好ID，-1表示不做修改（游戏内模拟拔线可以实时更新）");
            skinCardBack = config.Bind("Скины", "卡背", -1, "卡背的偏好ID，-1表示不做修改（实时生效）");
            skinBoard = config.Bind("Скины", "对战面板", -1, "（测试功能，可能会在酒馆卡住），对战面板替换，-1表示不做修改）");
            skinBgsBoard = config.Bind("Скины", "酒馆战斗面板", -1, "酒馆战斗面板的偏好ID，-1表示不做修改");
            skinBgsFinisher = config.Bind("Скины", "酒馆击杀特效", -1, "酒馆击杀的偏好ID，-1表示不做修改");
            skinBob = config.Bind("Скины", "鲍勃", -1, "鲍勃的偏好ID，-1表示不做修改");
            isSkinDefalutHeroEnable = config.Bind("Скины", "默认英雄", false, "如果可以，将对战英雄皮肤都替换为默认皮肤");
            skinHero = config.Bind("Скины", "英雄", -1, "（慎用，非挂机不建议使用，优先级低于默认英雄。一般情况下建议从文件加载英雄皮肤，修改完后F4更新；如果再对局中，则还需要模拟拔线）英雄的偏好ID，-1表示不做修改");
            skinOpposingHero = config.Bind("Скины", "对手英雄", -1, "（慎用，非挂机不建议使用，优先级低于默认英雄）对手英雄的偏好ID，-1表示不做修改");

            keyTimeGearUp = config.Bind("Горячие клавиши", "齿轮倍率+1", new KeyboardShortcut(KeyCode.UpArrow), "齿轮倍率增加1，默认方向上");
            keyTimeGearDown = config.Bind("Горячие клавиши", "齿轮倍率-1", new KeyboardShortcut(KeyCode.DownArrow), "齿轮倍率减少1，默认方向下");
            keyTimeGearDefault = config.Bind("Горячие клавиши", "齿轮倍率归零", new KeyboardShortcut(KeyCode.LeftArrow), "恢复默认齿轮倍率，默认方向左");
            keyTimeGearMax = config.Bind("Горячие клавиши", "齿轮倍率最大", new KeyboardShortcut(KeyCode.RightArrow), "齿轮倍率小于4时变为4，大于4时变为8，默认方向右");
            keySimulateDisconnect = config.Bind("Горячие клавиши", "模拟拔线", new KeyboardShortcut(KeyCode.D, KeyCode.LeftControl), "模拟掉线重连，注意需要禁用报错退出并允许弹出消息，默认左Ctrl+D");
            keyCopyBattleTag = config.Bind("Горячие клавиши", "复制对手战网标签", new KeyboardShortcut(KeyCode.C, KeyCode.LeftControl), "复制游戏内对手战网ID，默认左Ctrl+C");
            keyCopySelectBattleTag = config.Bind("Горячие клавиши", "复制所选对手战网标签", new KeyboardShortcut(KeyCode.Mouse0), "复制酒馆内所选对手战网ID，默认鼠标左键");
            keyConcede = config.Bind("Горячие клавиши", "投降", new KeyboardShortcut(KeyCode.Space, KeyCode.LeftControl), "投降，默认左Ctrl+空格");
            keyContinueMulligan = config.Bind("Горячие клавиши", "结束回合", new KeyboardShortcut(KeyCode.Space), "结束回合或替换卡牌确认，默认空格");
            keySquelch = config.Bind("Горячие клавиши", "沉默对手", new KeyboardShortcut(KeyCode.Q, KeyCode.LeftControl), "屏蔽你对手的表情，默认左Ctrl+Q");
            keySoundMute = config.Bind("Горячие клавиши", "静音/恢复音量", new KeyboardShortcut(KeyCode.S, KeyCode.LeftControl), "静音/恢复音量，默认左Ctrl+S");
            keyShutUpBob = config.Bind("Горячие клавиши", "闭了，鲍勃", new KeyboardShortcut(KeyCode.B, KeyCode.LeftControl), "禁用/恢复鲍勃语音，默认左Ctrl+B");
            keyRefund = config.Bind("Горячие клавиши", "一键全额分解", new KeyboardShortcut(KeyCode.Z, KeyCode.LeftControl), "一键分解全额分解的卡牌（仅在开包界面与收藏界面有效），默认左Ctrl+Z");
            //keyRuin = config.Bind("快捷键", "毁灭吧，赶紧的", new KeyboardShortcut(KeyCode.R, KeyCode.LeftControl), "一键退坑，默认左Ctrl+R");
            keyReadNewCards = config.Bind("Горячие клавиши", "朕，已阅！", new KeyboardShortcut(KeyCode.R, KeyCode.LeftControl), "消除所有新！标记（仅在开包界面与收藏界面有效；佣兵模式（有bug，重启后失效）下，执行后可能需要重新进入收藏），默认左Ctrl+R");
            keyShowFPS = config.Bind("Горячие клавиши", "显示/隐藏帧率", new KeyboardShortcut(KeyCode.P, KeyCode.LeftControl), "展示或隐藏游戏帧率信息，默认左Ctrl+P");

            keyEmoteGreetings = config.Bind("Горячие клавиши", "问候", new KeyboardShortcut(KeyCode.Alpha1), "表情问候，默认数字键1");
            keyEmoteWellPlayed = config.Bind("Горячие клавиши", "称赞", new KeyboardShortcut(KeyCode.Alpha2), "表情称赞，默认数字键2");
            keyEmoteThanks = config.Bind("Горячие клавиши", "感谢", new KeyboardShortcut(KeyCode.Alpha3), "表情感谢，默认数字键3");
            keyEmoteWow = config.Bind("Горячие клавиши", "惊叹", new KeyboardShortcut(KeyCode.Alpha4), "表情惊叹，默认数字键4");
            keyEmoteOops = config.Bind("Горячие клавиши", "失误", new KeyboardShortcut(KeyCode.Alpha5), "表情失误，默认数字键5");
            keyEmoteThreaten = config.Bind("Горячие клавиши", "威胁", new KeyboardShortcut(KeyCode.Alpha6), "表情威胁，默认数字键6");

            hsLogPath = config.Bind("Для разработчиков", "炉石日志", "", new ConfigDescription("炉石进程日志文件位置（相对于Hearthstone）", null, new object[] { "Advanced" }));
            hsMatchLogPath = config.Bind("Для разработчиков", "对局日志", @"BepInEx/HsMatch.log", "炉石对局日志文件位置（相对于Hearthstone），参数最先选用命令行");
            autoQuitTimer = config.Bind("Для разработчиков", "定时退出", (long)0, "当游戏运行x秒后（在对局结束时）自动退出，x<=0时该选项无效。");
            isFakeOpenEnable = config.Bind("Для разработчиков", "模拟开包状态", false, "是否启用模拟开包（修改该选项后建议重启炉石，启用时可能会导致卡包信息统计异常）");
            buyAdventure = config.Bind("Для разработчиков", "冒险购买", Utils.BuyAdventureTemplate.DoNothing, "（不建议购买卡拉赞）选择一个冒险进行购买尝试（有概率封号，酌情考虑使用）");
            isKarazhanFixEnable = config.Bind("Для разработчиков", "卡拉赞修复", false, "（请打完后请关闭，目前无法打序章）卡拉赞黑鸦翱翔修复，也可以用作冒险跳关。（有概率封号，酌情考虑使用）");
            webServerPort = config.Bind("Для разработчиков", "网站端口", 58744, new ConfigDescription("WebServer端口，参数最先选用命令行", new AcceptableValueRange<int>(1, 65535)));
            webPageBackImg = config.Bind("Для разработчиков", "网页背景图", "", new ConfigDescription("网页背景图片", null, new object[] { "Advanced" }));
            isWebshellEnable = config.Bind("Для разработчиков", "Webshell", false, "Webshell开关");
            isInternalModeEnable = config.Bind("Для разработчиков", "内部模式", false, "是否切换到内部模式（需要重启炉石）");

            fakeDevicePreset = config.Bind("Эмуляция", "设备模拟模板", Utils.DevicePreset.Default, "（重启炉石后生效）模拟设备，用于领取卡包卡背");
            fakeDeviceOs = config.Bind("Эмуляция", "设备模拟系统", OSCategory.PC, "模拟设备操作系统，当设备模拟模板为Custom时有效。");
            fakeDeviceScreen = config.Bind("Эмуляция", "设备屏幕大小", ScreenCategory.PC, "模拟尺寸（屏幕类型），当设备模拟模板为Custom时有效。");
            fakeDeviceName = config.Bind("Эмуляция", "设备设备型号", "HsMod", "模拟设备型号，当设备模拟模板为Custom时有效。");

            fakePackCount = config.Bind("Эмуляция", "数量", 233, "模拟卡包数量");
            fakeBoosterDbId = config.Bind("Эмуляция", "类型", BoosterDbId.GOLDEN_CLASSIC_PACK, "模拟卡包类型。(替换卡包图标)");
            isFakeRandomResult = config.Bind("Эмуляция", "随机结果", false, "是否启用随机结果");
            isFakeRandomRarity = config.Bind("Эмуляция", "随机稀有度", false, "是否随机稀有度（基于随机结果）");
            isFakeRandomPremium = config.Bind("Эмуляция", "随机品质", false, "是否随机品质（基于随机结果）");
            isFakeAtypicalRandomPremium = config.Bind("Эмуляция", "随机其他特效", false, "随机品质中包括钻石或异画等（基于随机品质）");
            fakeRandomRarity = config.Bind("Эмуляция", "稀有度类型", Utils.CardRarity.LEGENDARY, "指定随机稀有度（基于随机稀有度）");
            fakeRandomPremium = config.Bind("Эмуляция", "品质类型", TAG_PREMIUM.GOLDEN, "指定品质（基于随机品质）");

            fakeCatchupCount = config.Bind("Эмуляция", "追赶包卡牌数量，小于5时，数量随机", -1, new ConfigDescription("Catchup card num", null, new object[] { "Advanced" }));
            fakeCardID1 = config.Bind("Эмуляция", "卡牌1", 71984, new ConfigDescription("Card 1 DbID.", null, new object[] { "Advanced" }));
            fakeCardPremium1 = config.Bind("Эмуляция", "卡牌1品质", TAG_PREMIUM.GOLDEN, new ConfigDescription("Card 1 Premium.", null, new object[] { "Advanced" }));
            fakeCardID2 = config.Bind("Эмуляция", "卡牌2", 71945, new ConfigDescription("Card 2 DbID.", null, new object[] { "Advanced" }));
            fakeCardPremium2 = config.Bind("Эмуляция", "卡牌2品质", TAG_PREMIUM.GOLDEN, new ConfigDescription("Card 2 Premium.", null, new object[] { "Advanced" }));
            fakeCardID3 = config.Bind("Эмуляция", "卡牌3", 73446, new ConfigDescription("Card 3 DbID.", null, new object[] { "Advanced" }));
            fakeCardPremium3 = config.Bind("Эмуляция", "卡牌3品质", TAG_PREMIUM.GOLDEN, new ConfigDescription("Card 3 Premium.", null, new object[] { "Advanced" }));
            fakeCardID4 = config.Bind("Эмуляция", "卡牌4", 71781, new ConfigDescription("Card 4 DbID.", null, new object[] { "Advanced" }));
            fakeCardPremium4 = config.Bind("Эмуляция", "卡牌4品质", TAG_PREMIUM.GOLDEN, new ConfigDescription("Card 4 Premium.", null, new object[] { "Advanced" }));
            fakeCardID5 = config.Bind("Эмуляция", "卡牌5", 67040, new ConfigDescription("Card 5 DbID.", null, new object[] { "Advanced" }));
            fakeCardPremium5 = config.Bind("Эмуляция", "卡牌5品质", TAG_PREMIUM.GOLDEN, new ConfigDescription("Card 5 Premium.", null, new object[] { "Advanced" }));

            InitCardsMapping();
            LoadSkinsConfigFromFile();
            ConfigValueDelegate();
            ConfigTemplateSettingChanged(configTemplate.Value);
            timeKeeper = DateTime.Now.Ticks;


            if (CommandConfig.hsMatchLogPath == string.Empty) CommandConfig.hsMatchLogPath = hsMatchLogPath.Value;
            if (CommandConfig.webServerPort == -1) CommandConfig.webServerPort = webServerPort.Value;

        }

        public static void ConfigValueDelegate()
        {
            configTemplate.SettingChanged += delegate
            {
                ConfigTemplateSettingChanged(configTemplate.Value);
            };
            skinCardBack.SettingChanged += delegate
            {
                GameState gameState = GameState.Get();
                if (gameState != null)
                {
                    Player friendlySidePlayer = GameState.Get()?.GetFriendlySidePlayer();
                    if (friendlySidePlayer != null)
                        _ = friendlySidePlayer.GetCardBackId();
                    int opponentCardBackID = 0;
                    Player opposingSidePlayer = GameState.Get()?.GetOpposingSidePlayer();
                    if (opposingSidePlayer != null)
                        opponentCardBackID = opposingSidePlayer.GetCardBackId();
                    int friendlyCardBackID = skinCardBack.Value;
                    CardBackManager.Get().SetGameCardBackIDs(friendlyCardBackID, opponentCardBackID);
                }
            };
            buyAdventure.SettingChanged += delegate
            {
                if (buyAdventure.Value != Utils.BuyAdventureTemplate.DoNothing)
                {
                    Utils.BuyAdventure(buyAdventure.Value);
                    buyAdventure.Value = Utils.BuyAdventureTemplate.DoNothing;
                }
            };
        }

        public static void ConfigTemplateSettingChanged(Utils.ConfigTemplate cTemplate)
        {
            switch (cTemplate)
            {
                case Utils.ConfigTemplate.DoNothing:
                    return;
                case Utils.ConfigTemplate.AwayFromKeyboard:
                    isShortcutsEnable.Value = false;
                    isIGMMessageShow.Value = false;
                    isAlertPopupShow.Value = false;
                    responseAlertPopup.Value = Utils.AlertPopupResponse.YES;
                    isOnApplicationFocus.Value = false;
                    isRewardToastShow.Value = false;
                    isAutoOpenBoxesRewardEnable.Value = true;
                    isAutoExit.Value = true;
                    isIdleKickEnable.Value = true;
                    isQuickPackOpeningEnable.Value = true;
                    isAutoRefundCardDisenchantEnable.Value = true;
                    isAutoRecvMercenaryRewardEnable.Value = true;
                    isMercenaryBattleZoom.Value = false;
                    isSkipHeroIntro.Value = true;
                    isThinkEmotesEnable.Value = false;
                    receiveEnemyEmoteLimit.Value = 0;
                    isOpponentGoldenCardShow.Value = false;
                    skinCoin.Value = 1746;   // 初始幸运币
                    //isSkinDefalutHeroEnable.Value = true;
                    mercenaryDiamondCardState.Value = Utils.CardState.Disabled;
                    randomMercenarySkinEnable.Value = Utils.CardState.Disabled;
                    goldenCardState.Value = Utils.CardState.Disabled;
                    maxCardState.Value = Utils.CardState.Disabled;
                    configTemplate.Value = Utils.ConfigTemplate.DoNothing;
                    return;
                case Utils.ConfigTemplate.AntiAwayFromKeyboard:
                    isShortcutsEnable.Value = true;
                    isIGMMessageShow.Value = true;
                    isAlertPopupShow.Value = true;
                    responseAlertPopup.Value = Utils.AlertPopupResponse.DONOTHING;
                    isOnApplicationFocus.Value = false;
                    isRewardToastShow.Value = true;
                    isAutoOpenBoxesRewardEnable.Value = false;
                    isAutoExit.Value = false;
                    isIdleKickEnable.Value = false;
                    isQuickPackOpeningEnable.Value = true;
                    isAutoRefundCardDisenchantEnable.Value = false;
                    isAutoRecvMercenaryRewardEnable.Value = true;
                    isMercenaryBattleZoom.Value = false;
                    isSkipHeroIntro.Value = true;
                    isThinkEmotesEnable.Value = false;
                    receiveEnemyEmoteLimit.Value = 3;
                    isOpponentGoldenCardShow.Value = true;
                    skinCoin.Value = -1;
                    isSkinDefalutHeroEnable.Value = false;
                    goldenCardState.Value = Utils.CardState.Default;
                    maxCardState.Value = Utils.CardState.Default;
                    mercenaryDiamondCardState.Value = Utils.CardState.Default;
                    randomMercenarySkinEnable.Value = Utils.CardState.Default;
                    configTemplate.Value = Utils.ConfigTemplate.DoNothing;
                    return;
            }
        }

        public static void InitCardsMapping()
        {
            CardsMapping.Clear();
            Utils.CardMapping cardMapping = new Utils.CardMapping
            {
                ThisSkinType = Utils.SkinType.COIN,
                RealDbID = -1,
                FakeDbID = skinCoin.Value,
                RealCardID = "",
                FakeCardID = ""
                //FakeCardID = GameUtils.TranslateDbIdToCardId(skinCoin.Value)
            };
            if (cardMapping.FakeDbID != -1)
                CardsMapping.Add(cardMapping);
        }
        public static void UpdateCardsMapping()
        {
            for (int i = 0; i < CardsMapping.Count; i++)
            {
                if (CardsMapping[i].FakeDbID != -1 && CardsMapping[i].FakeCardID == "")
                {
                    Utils.CardMapping cardMapping = CardsMapping[i];
                    cardMapping.FakeCardID = GameUtils.TranslateDbIdToCardId(cardMapping.FakeDbID);
                    CardsMapping[i] = cardMapping;
                }
            }
        }
        public static void UpdateCardsMappingReal(string realCardID, Utils.SkinType skinType)
        {
            UpdateCardsMapping();
            for (int i = 0; i < CardsMapping.Count; i++)
            {
                if (CardsMapping[i].ThisSkinType == skinType)
                {
                    Utils.CardMapping cardMapping = CardsMapping[i];
                    cardMapping.RealCardID = realCardID;
                    cardMapping.RealDbID = GameUtils.TranslateCardIdToDbId(realCardID);
                    CardsMapping[i] = cardMapping;
                    break;
                }
            }
        }

        public static void LoadSkinsConfigFromFile(string file = "BepInEx/config/HsSkins.cfg")
        {
            HeroesMapping.Clear();
            if (File.Exists(file))
            {
                foreach (string line in File.ReadLines(file))
                {
                    if (line.StartsWith("#"))
                        continue;
                    else
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            if (!HeroesMapping.ContainsKey(int.Parse(parts[0])))
                            {
                                string[] skins = parts[1].Split(',');
                                HeroesMapping.Add(int.Parse(parts[0].Trim()), int.Parse(skins[new System.Random().Next(skins.Length)].Trim()));
                            }
                        }
                    }
                }
            }
            else
            {
                string newConfigFile = "# 皮肤映射表\n";
                newConfigFile += "# 说明：主要用作英雄（酒馆、对战）类皮肤替换；按下F4会在BepInEx目录下生成当前全部皮肤信息；\n";
                newConfigFile += "# 格式：原始皮肤:替换皮肤（:为半角字符）；下一行是一个样例(玛法里奥·怒风替换成大导师玛法里奥)，可以删除\n";
                newConfigFile += "#      亦支持a:b,c,d这种多值映射，实现随机皮肤。\n";
                newConfigFile += "274:57761\n\n";
                File.WriteAllText(file, newConfigFile);
            }
        }

        public static ConfigValue configValue = new ConfigValue();
    }



    //对外接口，
    public class ConfigValue
    {
        public bool IsOpponentRankInGameShowValue
        {
            get
            {
                if (GameUtils.IsGameTypeRanked()) return PluginConfig.isOpponentRankInGameShow.Value;
                else return false;
            }
            set { PluginConfig.isOpponentRankInGameShow.Value = value; }
        }
        public bool IsSkipHeroIntroValue
        {
            get { return PluginConfig.isSkipHeroIntro.Value; }
            set { PluginConfig.isSkipHeroIntro.Value = value; }
        }
        public bool IsShutUpBobEnableValue
        {
            get { return PluginConfig.isShutUpBobEnable.Value; }
            set { PluginConfig.isShutUpBobEnable.Value = value; }
        }
        public bool IsQuickPackOpeningEnableValue
        {
            get { return PluginConfig.isQuickPackOpeningEnable.Value; }
            set { PluginConfig.isQuickPackOpeningEnable.Value = value; }
        }
        public bool IsShowCardLargeCountValue
        {
            get { return PluginConfig.isShowCardLargeCount.Value; }
            set { PluginConfig.isShowCardLargeCount.Value = value; }
        }
        public bool IsMoveEnemyCardsEnableValue
        {
            get { return PluginConfig.isMoveEnemyCardsEnable.Value; }
            set { PluginConfig.isMoveEnemyCardsEnable.Value = value; }
        }
        public bool IsShowFPSEnableValue
        {
            get { return PluginConfig.isShowFPSEnable.Value; }
            set { PluginConfig.isShowFPSEnable.Value = value; }
        }
        public bool IsInternalModeEnableValue
        {
            get { return PluginConfig.isInternalModeEnable.Value; }
            set { PluginConfig.isInternalModeEnable.Value = value; }
        }
        public bool IsAlertPopupShowValue
        {
            get { return PluginConfig.isAlertPopupShow.Value; }
            set { PluginConfig.isAlertPopupShow.Value = value; }
        }
        public Utils.ConfigTemplate ConfigTemplateValue
        {
            set { PluginConfig.configTemplate.Value = value; }
        }
        public bool IsQuickModeEnableValue
        {
            get
            {
                return PluginConfig.isQuickModeEnable.Value && (GameMgr.Get().IsBattlegrounds() || (GameMgr.Get().IsMercenaries() && (GameMgr.Get().IsAI() || GameMgr.Get().IsLettuceTutorial() || GameMgr.Get().GetGameType() == PegasusShared.GameType.GT_VS_AI || GameMgr.Get().GetGameType() == PegasusShared.GameType.GT_MERCENARIES_AI_VS_AI || GameMgr.Get().GetGameType() == PegasusShared.GameType.GT_MERCENARIES_PVE)));
            }
            set { PluginConfig.isQuickModeEnable.Value = value; }
        }

        public bool IsTimeGearEnableValue
        {
            get { return PluginConfig.isTimeGearEnable.Value; }
            set { PluginConfig.isTimeGearEnable.Value = value; }
        }

        public bool TimeGearEnable
        {
            get { return PluginConfig.isTimeGearEnable.Value; }
            set { PluginConfig.isTimeGearEnable.Value = value; }
        }

        public int TimeGearValue
        {
            get { return PluginConfig.timeGear.Value; }
            set { PluginConfig.timeGear.Value = value; }
        }

        public long RunningTime
        {
            get { return (DateTime.Now.Ticks - PluginConfig.timeKeeper) / 10000000; }    // 返回秒
        }
        public bool IsBypassDeckShareCodeCheckEnable
        {
            get { return PluginConfig.isBypassDeckShareCodeCheckEnable.Value; }
            set { PluginConfig.isBypassDeckShareCodeCheckEnable.Value = value; }
        }
        public string HsMatchLogPathValue
        {
            get { return PluginConfig.CommandConfig.hsMatchLogPath; }
            set
            {
                PluginConfig.hsMatchLogPath.Value = value;
                PluginConfig.CommandConfig.hsMatchLogPath = value;
            }
        }

        public string CacheOpponentFullName
        {
            get
            {
                if (!String.IsNullOrEmpty(Utils.CacheLastOpponentFullName))
                    return Utils.CacheLastOpponentFullName;
                else if (!String.IsNullOrEmpty(BnetPresenceMgr.Get()?.GetPlayer(GameState.Get()?.GetOpposingSidePlayer()?.GetGameAccountId())?.GetFullName()))
                {
                    return BnetPresenceMgr.Get()?.GetPlayer(GameState.Get()?.GetOpposingSidePlayer()?.GetGameAccountId())?.GetFullName();
                }

                return "";
            }
        }

        public static ConfigValue Get()
        {
            return PluginConfig.configValue;
        }

    }
}
