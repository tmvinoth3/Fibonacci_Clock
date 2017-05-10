using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace FiboClock
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            Clear();
            FiboClock();
            
        }

        public void FiboClock()
        {
            DateTime t = DateTime.Now;
            showTime.Content = t.ToString("hh:mm");
            int hour = Convert.ToInt32(t.ToString("hh"));
            int minute = (Convert.ToInt32(t.ToString("mm"))) / 5;
            //int hour = Convert.ToInt32(tbHour.Text);
            //int minute = Convert.ToInt32(tbMinute.Text) / 5;
            SolidColorBrush RedBrush = new SolidColorBrush();
            RedBrush.Color = Colors.Red;
            SolidColorBrush GreenBrush = new SolidColorBrush();
            GreenBrush.Color = Colors.Green;
            SolidColorBrush BlueBrush = new SolidColorBrush();
            BlueBrush.Color = Colors.Blue;
            SolidColorBrush WhiteBrush = new SolidColorBrush();
            WhiteBrush.Color = Colors.White;

            if (hour == 12 && minute == 9)
            {
                five.Fill = BlueBrush;
                three.Fill = BlueBrush;
                onea.Fill = BlueBrush;
                two.Fill = RedBrush;
                oneb.Fill = RedBrush;
            }

            else if (hour == 12 && minute == 7)
            {
                five.Fill = BlueBrush;
                three.Fill = RedBrush;
                onea.Fill = RedBrush;
                two.Fill = BlueBrush;
                oneb.Fill = RedBrush;
            }

            else
            {

                if (hour / 5 >= 1 && minute / 5 >= 1)
                {
                    //brush.Color = Colors.Blue;
                    five.Fill = BlueBrush;
                    hour = hour - 5;
                    minute = minute - 5;
                }
                else if (hour / 5 >= 1 && minute / 5 < 1)
                {
                    // brush.Color = Colors.Red;
                    five.Fill = RedBrush;

                    if (minute == 1)
                    {
                        oneb.Fill = GreenBrush;
                        minute -= 1;
                    }


                    else if (minute == 2 && hour == 12)
                    {
                        two.Fill = BlueBrush;
                        minute -= 2;
                    }
                    else if (minute == 2)
                    {
                        two.Fill = GreenBrush;
                        minute -= 2;
                    }

                    else if (minute == 3)
                    {
                        if (hour - 5 >= 5)
                        {
                            if (hour - 5 == 5)
                            {
                                three.Fill = BlueBrush;
                            }
                            else if (hour - 5 == 6)
                            {
                                three.Fill = BlueBrush;
                                two.Fill = RedBrush;
                                onea.Fill = RedBrush;
                                hour = hour - 3;
                            }
                            else if (hour - 5 == 7)
                            {
                                three.Fill = BlueBrush;
                                two.Fill = RedBrush;
                                onea.Fill = RedBrush;
                                oneb.Fill = RedBrush;
                                hour = hour - 4;
                            }
                            hour -= 3;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                        }
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {
                        if (hour - 5 >= 5)
                        {
                            if (hour - 5 == 5)
                            {
                                three.Fill = BlueBrush;
                                oneb.Fill = BlueBrush;
                            }
                            else if (hour - 5 == 6)
                            {
                                three.Fill = BlueBrush;
                                two.Fill = RedBrush;
                                onea.Fill = BlueBrush;
                                hour -= 2;
                            }
                            else if (hour - 5 == 7)
                            {
                                three.Fill = BlueBrush;
                                two.Fill = RedBrush;
                                onea.Fill = RedBrush;
                                oneb.Fill = BlueBrush;
                                hour -= 3;
                            }
                            hour -= 4;
                        }

                        else
                        {
                            three.Fill = GreenBrush;
                            oneb.Fill = GreenBrush;
                        }
                        minute -= 4;
                    }
                    hour = hour - 5;
                    // minute = 0;
                }
                //for 3///////////////////////////////////////////////////////////////////////////////////////////////
                if (hour / 3 >= 1 && minute / 3 >= 1)
                {

                    three.Fill = BlueBrush;
                    hour = hour - 3;
                    minute = minute - 3;
                }

                else if (hour / 3 >= 1 && minute / 3 < 1)
                {



                    Color c = (three.Fill as SolidColorBrush).Color;
                    Color d = (two.Fill as SolidColorBrush).Color;
                    Color e = (onea.Fill as SolidColorBrush).Color;
                    Color f = (oneb.Fill as SolidColorBrush).Color;
                    if (c != Colors.White)
                    {
                        two.Fill = RedBrush;
                        onea.Fill = RedBrush;
                    }
                    if (c != Colors.White && d == Colors.White && e == Colors.White)
                    {
                        oneb.Fill = RedBrush;
                    }
                    else
                    {
                        three.Fill = RedBrush;
                    }
                    if (c != Colors.White && d == Colors.White && f != Colors.White)
                    {
                        oneb.Fill = BlueBrush;
                    }

                    if (minute == 1)
                    {
                        oneb.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {
                        two.Fill = GreenBrush;
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {
                        three.Fill = GreenBrush;
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {
                        three.Fill = GreenBrush;
                        onea.Fill = GreenBrush;
                        minute -= 4;
                    }
                    hour = hour - 3;
                    //minute = 0;
                }

                //for 2///////////////////////////////////////////////////////////////////////////////////////////////
                if (hour / 2 >= 1 && minute / 2 >= 1)
                {
                    two.Fill = BlueBrush;
                    hour = hour - 2;
                    minute = minute - 2;
                }

                else if (hour / 2 >= 1 && minute / 2 < 1)
                {

                    Color c = (two.Fill as SolidColorBrush).Color;
                    if (c != Colors.White)
                    {
                        onea.Fill = RedBrush;
                        oneb.Fill = RedBrush;
                    }
                    else
                    {
                        two.Fill = RedBrush;
                    }


                    if (minute == 1)
                    {
                        onea.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {

                        two.Fill = GreenBrush;
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {

                        three.Fill = GreenBrush;
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {

                        three.Fill = GreenBrush;
                        onea.Fill = GreenBrush;
                        minute -= 4;
                    }
                    hour = hour - 2;
                    //minute = 0;
                }





                //for1a///////////////////////////////////////////////////////////////////////////////////////////////
                if (hour / 1 >= 1 && minute / 1 >= 1)
                {
                    onea.Fill = BlueBrush;
                    hour = hour - 1;
                    minute = minute - 1;
                }

                else if (hour / 1 >= 1 && minute / 1 < 1)
                {
                    onea.Fill = RedBrush;
                    if (minute == 1)
                    {
                        onea.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {

                        two.Fill = GreenBrush;
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {

                        three.Fill = GreenBrush;
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {

                        three.Fill = GreenBrush;
                        onea.Fill = GreenBrush;
                        minute -= 4;
                    }
                    hour = hour - 1;
                    //minute = 0;
                }

                else if (hour / 1 < 1 && minute <= 4)
                {

                    //two.Fill = RedBrush;
                    if (minute == 1)
                    {
                        onea.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {


                        Color c = (two.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            oneb.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                        }
                        else
                        {
                            two.Fill = GreenBrush;
                        }
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {
                        Color c = (three.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            two.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                        }
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {
                        Color c = (three.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            two.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                            oneb.Fill = GreenBrush;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                        }
                        minute -= 4;
                    }
                    //hour = hour - 2;
                    //minute = 0;
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (hour / 1 >= 1 && minute / 1 >= 1)
                {
                    oneb.Fill = BlueBrush;
                    hour = hour - 1;
                    minute = minute - 1;
                }

                else if (hour / 1 >= 1 && minute / 1 < 1)
                {
                    oneb.Fill = RedBrush;

                    Color c = (onea.Fill as SolidColorBrush).Color;
                    Color d = (two.Fill as SolidColorBrush).Color;
                    Color e = (three.Fill as SolidColorBrush).Color;
                    Color f = (five.Fill as SolidColorBrush).Color;

                    if (c == Colors.Red && d == Colors.Red && e == Colors.Red && f == Colors.Red)
                    {
                        oneb.Fill = BlueBrush;
                    }


                    if (minute == 1)
                    {
                        onea.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {
                        two.Fill = GreenBrush;
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {
                        three.Fill = GreenBrush;
                        minute -= 3;
                    }
                    else if (minute == 4)
                    {
                        three.Fill = GreenBrush;
                        onea.Fill = GreenBrush;
                        minute -= 4;
                    }
                    hour = hour - 1;
                    // minute = 0;
                }

                else if (hour / 1 < 1 && minute <= 4)
                {

                    //two.Fill = RedBrush;
                    if (minute == 1)
                    {
                        oneb.Fill = GreenBrush;
                        minute -= 1;
                    }
                    else if (minute == 2)
                    {
                        two.Fill = GreenBrush;
                        minute -= 2;
                    }
                    else if (minute == 3)
                    {

                        Color c = (three.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            two.Fill = GreenBrush;
                            oneb.Fill = GreenBrush;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                        }

                        minute -= 3;
                    }
                    else if (minute == 4)
                    {


                        Color c = (three.Fill as SolidColorBrush).Color;
                        Color d = (onea.Fill as SolidColorBrush).Color;
                        if (c != Colors.White && d != Colors.White)
                        {
                            onea.Fill = RedBrush;
                            five.Fill = GreenBrush;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                            oneb.Fill = GreenBrush;
                        }


                        minute -= 4;
                    }
                    // hour = hour - 2;
                    //minute = 0;
                }

                else if (hour / 1 < 1 && minute >= 5 && minute <= 10)
                {

                    //two.Fill = RedBrush;
                    if (minute == 5)
                    {


                        Color c = (five.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            three.Fill = GreenBrush;
                            two.Fill = GreenBrush;
                        }
                        else
                        {
                            five.Fill = GreenBrush;
                        }


                    }
                    if (minute == 6)
                    {

                        Color c = (five.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            three.Fill = GreenBrush;
                            two.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                        }
                        else
                        {
                            five.Fill = GreenBrush;
                            oneb.Fill = GreenBrush;
                        }

                    }
                    if (minute == 7)
                    {
                        five.Fill = GreenBrush;
                        two.Fill = GreenBrush;
                    }
                    if (minute == 8)
                    {
                        five.Fill = GreenBrush;


                        Color c = (three.Fill as SolidColorBrush).Color;
                        if (c != Colors.White)
                        {
                            two.Fill = GreenBrush;
                            onea.Fill = GreenBrush;
                        }
                        else
                        {
                            three.Fill = GreenBrush;
                        }
                        minute -= 4;



                    }
                    if (minute == 9)
                    {
                        five.Fill = GreenBrush;
                        three.Fill = GreenBrush;
                        oneb.Fill = GreenBrush;
                    }
                    if (minute == 10)
                    {
                        five.Fill = GreenBrush;
                        three.Fill = GreenBrush;
                        two.Fill = GreenBrush;
                    }

                }


                //for hour and minute zero
                if (hour == 0 && minute == 0)
                {
                    showTime.Content = "Fibonacci Clock";
                }



            }
        }

        private void Clock_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            FiboClock();
        }

        public void Clear()
        {
            SolidColorBrush WhiteBrush = new SolidColorBrush();
            WhiteBrush.Color = Colors.White;
            onea.Fill = WhiteBrush;
            oneb.Fill = WhiteBrush;
            two.Fill = WhiteBrush;
            three.Fill = WhiteBrush;
            five.Fill = WhiteBrush;
        }
    }
}
