using Overwatch_Companion_2._0.Assets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Overwatch_Companion_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Hero> Heroes;
        private List<Hero> AllHeroes;

        public MainPage()
        {
            this.InitializeComponent();
            Heroes = HeroManager.GetHeroes();
            AllHeroes = HeroManager.GetHeroes();
            
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var hero = (Hero)e.ClickedItem;
            var HeroDataTemplate = (Hero)e.ClickedItem;
            
            //This image is for the one that pops up after clicking on a hero on the left
            //Image img = new Image();
            //HeroImageRight.Source = new BitmapImage(new Uri("ms-appx:///" + hero.HeroImage));
            BackgroundDesignTextImage.Source = new BitmapImage(new Uri("ms-appx:///" + hero.HeroImage));
            BackgroundDesignTextImage.Opacity = 0.4;
            
            HeroNameTextBlock.Text = hero.HeroName;
            HeroDifficultyTextBlock.Text = "Difficulty = " + hero.HeroDifficulty.ToString();
            HeroStrengthsTitleTextBlock.Text = "Strengths"; HeroWeaknessesTitleTextBlock.Text = "Weaknesses";
            HeroStrengthsTextBlock.Text = hero.HeroStrengths; HeroWeaknessesTextBlock.Text = hero.HeroWeaknesses;
            HeroStatsTitleTextBlock.Text = "Stats"; HeroHealthArmorShieldTitle.Text = "Health: ";
            HeroHealthArmorShieldTextBlock.Text = hero.HeroHealthArmorShield; HeroLeftClickDamageTitle.Text = "Left Click: ";
            HeroLeftClickDamageTextBlock.Text = hero.HeroLeftClickDamage; HeroRightClickDamageTitle.Text = "Right Click: ";
            HeroRightClickDamageTextBlock.Text = hero.HeroRightClickDamage; HeroSpeedTitle.Text = "Speed: ";
            HeroSpeed.Text = hero.HeroSpeed; HeroAbilitiesTitle.Text = "Abilities";
            HeroPassiveName.Text = "Passive: " + hero.HeroPassiveName; HeroPassive.Text = hero.HeroPassive;
            HeroAbility1Name.Text = "Ability 1: " + hero.HeroAbility1Name; HeroAbility1.Text = hero.HeroAbility1;
            HeroAbility2Name.Text = "Ability 2: " + hero.HeroAbility2Name; HeroAbility2.Text = hero.HeroAbility2;
            HeroUltimateName.Text = "Ultimate: " + hero.HeroUltimateName; HeroUltimate.Text = hero.HeroUltimate;
            HeroTipsAndTricksTitleTextBlock.Text = "Tips and Tricks"; HeroTipsAndTricksTextBlock.Text = hero.HeroTipsAndTricks;
        }

        //sets the information displayed to the given hero, if that hero exists
        private void HeroSearched(string heroName)
        {
            var hero = AllHeroes[0];

            for (int i = 0; i < AllHeroes.Count; i++)
            {
                if (AllHeroes[i].HeroName.Equals(heroName))
                {
                    hero = AllHeroes[i];
                    break;
                }
                else
                {
                    hero = AllHeroes[0];
                }
            }

            //This image is for the one that pops up after clicking on a hero on the left
            //Image img = new Image();
            //HeroImageRight.Source = new BitmapImage(new Uri("ms-appx:///" + hero.HeroImage));
            BackgroundDesignTextImage.Source = new BitmapImage(new Uri("ms-appx:///" + hero.HeroImage));
            BackgroundDesignTextImage.Opacity = 0.5;
            
            HeroNameTextBlock.Text = hero.HeroName;
            HeroDifficultyTextBlock.Text = "Difficulty = " + hero.HeroDifficulty.ToString();
            HeroStrengthsTitleTextBlock.Text = "Strengths";  HeroWeaknessesTitleTextBlock.Text = "Weaknesses";
            HeroStrengthsTextBlock.Text = hero.HeroStrengths; HeroWeaknessesTextBlock.Text = hero.HeroWeaknesses;
            HeroStatsTitleTextBlock.Text = "Stats"; HeroHealthArmorShieldTitle.Text = "Health: ";
            HeroHealthArmorShieldTextBlock.Text = hero.HeroHealthArmorShield; HeroLeftClickDamageTitle.Text = "Left Click: ";
            HeroLeftClickDamageTextBlock.Text = hero.HeroLeftClickDamage; HeroRightClickDamageTitle.Text = "Right Click: ";
            HeroRightClickDamageTextBlock.Text = hero.HeroRightClickDamage; HeroSpeedTitle.Text = "Speed: ";
            HeroSpeed.Text = hero.HeroSpeed; HeroAbilitiesTitle.Text = "Abilities";
            HeroPassiveName.Text = "Passive: " + hero.HeroPassiveName; HeroPassive.Text = hero.HeroPassive;
            HeroAbility1Name.Text = "Ability 1: " + hero.HeroAbility1Name; HeroAbility1.Text = hero.HeroAbility1;
            HeroAbility2Name.Text = "Ability 2: " + hero.HeroAbility2Name; HeroAbility2.Text = hero.HeroAbility2;
            HeroUltimateName.Text = "Ultimate: " + hero.HeroUltimateName; HeroUltimate.Text = hero.HeroUltimate;
            HeroTipsAndTricksTitleTextBlock.Text = "Tips and Tricks"; HeroTipsAndTricksTextBlock.Text = hero.HeroTipsAndTricks;
        }

        //checks if the AllHeroes list contains the given text
        private bool containsHero(string heroName)
        {
            if (heroName == null) return false;

            for(int i = 0; i < AllHeroes.Count; i++)
            {
                if (AllHeroes[i].HeroName.Equals(heroName)) return true;
            }
            return false;
        }
        
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                List<string> listOfHeroes = null;

                //Set the ItemsSource to be your filtered dataset

                //List<string> heroList = new List<string> {"Ana", "Ashe", "Baptiste",
                //"Bastion", "Brigitte", "D.Va", "Doomfist", "Genji", "Hanzo", "Junkrat", "Lucio", "McCree", "Mei",
                //"Mercy", "Moira", "Orisa", "Pharah", "Reaper", "Reinhardt", "Roadhog", "Soldier 76", "Sombra", "Symmetra",
                //"Torbjorn", "Tracer", "Widowmaker", "Winston", "Wrecking Ball", "Zarya", "Zenyatta"};
                
                //This does same thing as above 
                List<string> heroList = new List<string>();
                for (int i = 0; i < AllHeroes.Count; i++)
                {
                    heroList.Add(AllHeroes[i].HeroName);
                }

                string userSearchString = sender.Text;
                if (string.IsNullOrEmpty(userSearchString))
                {
                    sender.ItemsSource = listOfHeroes;
                }
                else
                {
                    userSearchString = userSearchString.ToLower();
                    //userSearchString = char.ToUpper(userSearchString[0]) + userSearchString.Substring(1);

                    listOfHeroes = heroList.Where(x => x.ToLower().StartsWith(userSearchString)).ToList();

                    if (listOfHeroes.Count == 0) listOfHeroes.Add("No heroes found");

                    sender.ItemsSource = listOfHeroes;
                }
                
            }
    
        }
    
        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.

            //string heroName = (string)args.SelectedItem;

            //heroName = char.ToUpper(heroName[0]) + heroName.Substring(1);

            //sender.Text =  (string)args.SelectedItem;

            //if (sender.Text.Equals("No heroes found")) sender.Text = null;
        }

        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null && containsHero(args.QueryText) == true)
            {
                // User selected an item from the suggestion list, take an action on it here.
                //TestTextBlock.Visibility = Visibility.Visible;
                HeroSearched(sender.Text);
            }
            else if (sender.Text != null)
            {
                List<string> listOfHeroes = null;
                
                List<string> heroList = new List<string>();

                for (int i = 0; i < AllHeroes.Count; i++)
                {
                    heroList.Add(AllHeroes[i].HeroName);
                }

                string userSearchString = sender.Text;
                if (string.IsNullOrEmpty(userSearchString))
                {
                    HeroSearched(listOfHeroes[0]);
                    sender.Text = listOfHeroes[0];
                }
                else
                {
                    userSearchString = userSearchString.ToLower();

                    listOfHeroes = heroList.Where(x => x.ToLower().StartsWith(userSearchString)).ToList();

                    if (listOfHeroes.Count > 0)
                    {
                        HeroSearched(listOfHeroes[0]);
                        sender.Text = listOfHeroes[0];
                    }
                    else
                    {
                        HeroSearched(AllHeroes[0].HeroName);
                        sender.Text = AllHeroes[0].HeroName;
                    }
                }
            }
            else
            {
                // Use args.QueryText to determine what to do.
                AutoSuggestBoxSearchHeroes.PlaceholderText = "Search Heroes...";
            }
        }

        private void RandomHeroGeneratorButton_Click(object sender, RoutedEventArgs e)
        {
            //List<string> heroList = new List<string> {"Ana", "Ashe", "Baptiste",
            //    "Bastion", "Brigitte", "D.Va", "Doomfist", "Genji", "Hanzo", "Junkrat", "Lucio", "McCree", "Mei",
            //    "Mercy", "Moira", "Orisa", "Pharah", "Reaper", "Reinhardt", "Roadhog", "Soldier 76", "Sombra", "Symmetra",
            //    "Torbjorn", "Tracer", "Widowmaker", "Winston", "Wrecking Ball", "Zarya", "Zenyatta"};

            //This does same thing as above
            List<string> heroList = new List<string>();
            for (int i = 0; i < AllHeroes.Count; i++)
            {
                heroList.Add(AllHeroes[i].HeroName);
            }

            Random rnd = new Random();
            
            GenerateRandomNameWithDelay(rnd, heroList);
            
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(100);
        }

        private async void GenerateRandomNameWithDelay(Random rnd, List<string> heroList)
        {
            string randomHero = "";
            for (int i = 0; i < 9; i++)
            {
                await PutTaskDelay();

                RandomHeroGeneratorButton.FontSize = 11;
                randomHero = heroList[rnd.Next(heroList.Count)];
                RandomHeroGeneratorButton.Content = randomHero;

            }

            RandomHeroGeneratorButton.FontSize = 15;
            HeroSearched(randomHero);
        }

        private void ColumnItem1_Click(object sender, RoutedEventArgs e)
        {
            GridViewHeroList.Width = 155;
            RandomHeroGeneratorButton.Margin = Margin_0_32_0_0.Margin;
            OptionsButton.Margin = Margin_64_0_0_0.Margin;
        }

        private void ColumnItem2_Click(object sender, RoutedEventArgs e)
        {
            GridViewHeroList.Width = 310;
            RandomHeroGeneratorButton.Margin = Margin_0_32_0_0.Margin;
            OptionsButton.Margin = Margin_152_0_0_0.Margin;
        }

        private void ColumnItem3_Click(object sender, RoutedEventArgs e)
        {
            GridViewHeroList.Width = 465;
            RandomHeroGeneratorButton.Margin = Margin_152_0_0_0.Margin;
            OptionsButton.Margin = Margin_302_0_0_0.Margin;
        }

        private void ColumnItem4_Click(object sender, RoutedEventArgs e)
        {
            GridViewHeroList.Width = 620;
            RandomHeroGeneratorButton.Margin = Margin_152_0_0_0.Margin;
            OptionsButton.Margin = Margin_302_0_0_0.Margin;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            //This image is for the one that pops up after clicking on a hero on the left
            //Image img = new Image();
            //HeroImageRight.Source = new BitmapImage(new Uri("ms-appx:///ThisDoesNotExist"));
            BackgroundDesignTextImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/NoHeroClicked.png"));
            BackgroundDesignTextImage.Opacity = 1.0;
            
            HeroNameTextBlock.Text = ""; HeroDifficultyTextBlock.Text = ""; HeroStrengthsTitleTextBlock.Text = "";
            HeroWeaknessesTitleTextBlock.Text = ""; HeroStrengthsTextBlock.Text = ""; HeroWeaknessesTextBlock.Text = "";
            HeroStatsTitleTextBlock.Text = ""; HeroHealthArmorShieldTitle.Text = ""; HeroHealthArmorShieldTextBlock.Text = "";
            HeroLeftClickDamageTitle.Text = ""; HeroLeftClickDamageTextBlock.Text = ""; HeroRightClickDamageTitle.Text = "";
            HeroRightClickDamageTextBlock.Text = ""; HeroSpeedTitle.Text = ""; HeroSpeed.Text = "";
            HeroAbilitiesTitle.Text = ""; HeroPassiveName.Text = ""; HeroPassive.Text = "";
            HeroAbility1Name.Text = ""; HeroAbility1.Text = ""; HeroAbility2Name.Text = "";
            HeroAbility2.Text = "";  HeroUltimateName.Text = ""; HeroUltimate.Text = "";
            HeroTipsAndTricksTitleTextBlock.Text = ""; HeroTipsAndTricksTextBlock.Text = "";

            AutoSuggestBoxSearchHeroes.Text = "";

            Heroes = HeroManager.GetHeroes();

            GridViewHeroList.ItemsSource = Heroes;

            RandomHeroGeneratorButton.FontSize = 11;
            RandomHeroGeneratorButton.Content = "Random Hero Generator";

        }

        private void GiveFeedback_Click(object sender, RoutedEventArgs e)
        {
            FeedbackStackPanel.Visibility = Visibility.Visible;
        }

        private void CloseFeedbackTextBox_Click(object sender, RoutedEventArgs e)
        {
            FeedbackStackPanel.Visibility = Visibility.Collapsed;
        }

        //This method will make the Heroes list contain ALL the heroes
        private void ListAllHeroes_Click(object sender, RoutedEventArgs e)
        {

            Heroes = HeroManager.GetHeroes();

            GridViewHeroList.ItemsSource = Heroes;

        }
        //This method will make the Heroes list only contain the DAMAGE heroes
        private void ListDamageHeroes_Click(object sender, RoutedEventArgs e)
        {
            var damageHeroes = new List<Hero>();
            List<Hero> allHeroes = HeroManager.GetHeroes();

            for (int i = 0; i < HeroManager.GetHeroes().Count; i++)
            {
                if (allHeroes[i].HeroClass.Equals("damage"))
                {
                    addHeroToList(i, damageHeroes, allHeroes);
                }

            }

            Heroes = damageHeroes;

            GridViewHeroList.ItemsSource = Heroes;
        }

        private void ListTankHeroes_Click(object sender, RoutedEventArgs e)
        {
            var tankHeroes = new List<Hero>();
            List<Hero> allHeroes = HeroManager.GetHeroes();

            for (int i = 0; i < HeroManager.GetHeroes().Count; i++)
            {
                if (allHeroes[i].HeroClass.Equals("tank"))
                {
                    addHeroToList(i, tankHeroes, allHeroes);
                }

            }

            Heroes = tankHeroes;

            GridViewHeroList.ItemsSource = Heroes;
            
        }

        private void ListSupportHeroes_Click(object sender, RoutedEventArgs e)
        {
            var supportHeroes = new List<Hero>();
            List<Hero> allHeroes = HeroManager.GetHeroes();

            for (int i = 0; i < HeroManager.GetHeroes().Count; i++)
            {
                if (allHeroes[i].HeroClass.Equals("support"))
                {
                    addHeroToList(i, supportHeroes, allHeroes);
                }

            }

            Heroes = supportHeroes;

            GridViewHeroList.ItemsSource = Heroes;
            
        }

        private void addHeroToList(int i, List<Hero> heroes, List<Hero> allHeroes)
        {
            heroes.Add(new Hero
            {
                HeroId = allHeroes[i].HeroId, HeroName = allHeroes[i].HeroName, HeroImage = allHeroes[i].HeroImage,
                HeroSmallerImage = allHeroes[i].HeroSmallerImage, HeroDifficulty = allHeroes[i].HeroDifficulty,
                HeroStrengths = allHeroes[i].HeroStrengths, HeroWeaknesses = allHeroes[i].HeroWeaknesses,
                HeroHealthArmorShield = allHeroes[i].HeroHealthArmorShield, HeroLeftClickDamage = allHeroes[i].HeroLeftClickDamage,
                HeroRightClickDamage = allHeroes[i].HeroRightClickDamage, HeroSpeed = allHeroes[i].HeroSpeed,
                HeroPassiveName = allHeroes[i].HeroPassiveName, HeroPassive = allHeroes[i].HeroPassive,
                HeroAbility1Name = allHeroes[i].HeroAbility1Name, HeroAbility1 = allHeroes[i].HeroAbility1,
                HeroAbility2Name = allHeroes[i].HeroAbility2Name, HeroAbility2 = allHeroes[i].HeroAbility2,
                HeroUltimateName = allHeroes[i].HeroUltimateName, HeroUltimate = allHeroes[i].HeroUltimate,
                HeroTipsAndTricks = allHeroes[i].HeroTipsAndTricks, HeroClass = allHeroes[i].HeroClass
            });

        }

        //private void DarkmodeToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        //{
        //    ToggleSwitch darkmodeToggleSwitch = sender as ToggleSwitch;
        //    if (darkmodeToggleSwitch != null)
        //    {
        //        if (darkmodeToggleSwitch.IsOn == true)
        //        {
        //            MainGrid.Background = BlueGrid.Background;

        //            //change the font color here
        //            HeroNameTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroDifficultyTextBlock.Foreground = WhiteFontTextblock.Foreground; HeroStrengthsTitleTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroWeaknessesTitleTextBlock.Foreground = WhiteFontTextblock.Foreground; HeroStrengthsTextBlock.Foreground = WhiteFontTextblock.Foreground; 
        //            HeroWeaknessesTextBlock.Foreground = WhiteFontTextblock.Foreground; HeroStatsTitleTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroHealthArmorShieldTitle.Foreground = WhiteFontTextblock.Foreground;  HeroHealthArmorShieldTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroLeftClickDamageTitle.Foreground = WhiteFontTextblock.Foreground; HeroLeftClickDamageTextBlock.Foreground = WhiteFontTextblock.Foreground; 
        //            HeroRightClickDamageTitle.Foreground = WhiteFontTextblock.Foreground; HeroRightClickDamageTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroSpeedTitle.Foreground = WhiteFontTextblock.Foreground; HeroSpeed.Foreground = WhiteFontTextblock.Foreground;
        //            HeroAbilitiesTitle.Foreground = WhiteFontTextblock.Foreground; HeroPassiveName.Foreground = WhiteFontTextblock.Foreground;
        //            HeroPassive.Foreground = WhiteFontTextblock.Foreground; HeroAbility1Name.Foreground = WhiteFontTextblock.Foreground;
        //            HeroAbility1.Foreground = WhiteFontTextblock.Foreground; HeroAbility2Name.Foreground = WhiteFontTextblock.Foreground;
        //            HeroAbility2.Foreground = WhiteFontTextblock.Foreground; HeroUltimateName.Foreground = WhiteFontTextblock.Foreground;
        //            HeroUltimate.Foreground = WhiteFontTextblock.Foreground; HeroTipsAndTricksTitleTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //            HeroTipsAndTricksTextBlock.Foreground = WhiteFontTextblock.Foreground;
        //        }
        //        else
        //        {
        //            MainGrid.Background = WhiteGrid.Background;

        //            HeroNameTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroDifficultyTextBlock.Foreground = BlackFontTextblock.Foreground; HeroStrengthsTitleTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroWeaknessesTitleTextBlock.Foreground = BlackFontTextblock.Foreground; HeroStrengthsTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroWeaknessesTextBlock.Foreground = BlackFontTextblock.Foreground; HeroStatsTitleTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroHealthArmorShieldTitle.Foreground = BlackFontTextblock.Foreground; HeroHealthArmorShieldTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroLeftClickDamageTitle.Foreground = BlackFontTextblock.Foreground; HeroLeftClickDamageTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroRightClickDamageTitle.Foreground = BlackFontTextblock.Foreground; HeroRightClickDamageTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroSpeedTitle.Foreground = BlackFontTextblock.Foreground; HeroSpeed.Foreground = BlackFontTextblock.Foreground;
        //            HeroAbilitiesTitle.Foreground = BlackFontTextblock.Foreground; HeroPassiveName.Foreground = BlackFontTextblock.Foreground;
        //            HeroPassive.Foreground = BlackFontTextblock.Foreground; HeroAbility1Name.Foreground = BlackFontTextblock.Foreground;
        //            HeroAbility1.Foreground = BlackFontTextblock.Foreground; HeroAbility2Name.Foreground = BlackFontTextblock.Foreground;
        //            HeroAbility2.Foreground = BlackFontTextblock.Foreground; HeroUltimateName.Foreground = BlackFontTextblock.Foreground;
        //            HeroUltimate.Foreground = BlackFontTextblock.Foreground; HeroTipsAndTricksTitleTextBlock.Foreground = BlackFontTextblock.Foreground;
        //            HeroTipsAndTricksTextBlock.Foreground = BlackFontTextblock.Foreground;
        //        }
        //    }



        //}
    }
}
