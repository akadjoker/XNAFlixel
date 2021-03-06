﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;
using org.flixel.examples;

using System.Linq;
using System.Xml.Linq;

namespace org.flixel.examples
{
    /// <summary>
    /// This is a test state.
    /// </summary>
    public class TestState : FlxState
    {

        private FlxText mouseInfo;

        override public void create()
        {
            base.create();

            FlxG.mouse.show(FlxG.Content.Load<Texture2D>("flixel/cursor"));

            mouseInfo = new FlxText(1, 1, 100);
            mouseInfo.text = "Info:";
            mouseInfo.alignment = FlxJustification.Left;
            mouseInfo.setScrollFactors(1, 1);
            add(mouseInfo);

            FlxG.resetHud();

            string textInfo = "";
            textInfo = "Choose:\n";
            textInfo += "1. Cheat State\n";
            textInfo += "2. Cave State\n";
            textInfo += "3. Race Or Die\n";
            textInfo += "4. Tweens\n";
            textInfo += "5. Robot Football\n";
            textInfo += "6. Animation Callbacks\n";
            textInfo += "7. FlxPath \n";
            textInfo += "8. Physics \n";
            textInfo += "9. Angle And Velocity\n";
            textInfo += "F2. Physics 2\n";
            textInfo += "F3. Island \n";
            textInfo += "F4. Island 2 \n";
            textInfo += "F5. Physics Hockey \n";
            textInfo += "F6. FlxBar \n";
            textInfo += "F7. Scrolling Test \n";

            textInfo += "Q. Garbage Tests \n";
            FlxG.setHudText(1, textInfo);
            FlxG.setHudTextPosition(1, 50, 20);
            FlxG.setHudTextScale(1, 2);
            FlxG.setHudGamepadButton(FlxHud.TYPE_KEYBOARD, FlxHud.Keyboard_1, FlxG.width - 120, 30);

            FlxG.showHud();

            /*
			FlxSprite logo = new FlxSprite(12, 12);
			logo.loadGraphic("flixel/surt/race_or_die", true, false, 64, 64);
			logo.addAnimation("Static", new int[] { 8 }, 0, true);
			logo.play("Static");
			logo.setDrags(5, 5);
			add(logo);
            */

        }

        override public void update()
        {

            mouseInfo.text = string.Format("x: {0} y: {1}\nLeft press {2} \nRight press {3}\nLeft click {4} \nRight click {5}", FlxG.mouse.x, FlxG.mouse.y, FlxG.mouse.pressedLeftButton(), FlxG.mouse.pressedRightButton(), FlxG.mouse.justPressedLeftButton(), FlxG.mouse.justPressedRightButton());
            mouseInfo.x = FlxG.mouse.x;
            mouseInfo.y = FlxG.mouse.y;



			#if OSX 
			#endif
			#if WINDOWS
            if (FlxG.keys.justPressed(Keys.Q))
            {
                FlxG.state = new DebugMenuState();
            }
            
            
            
            if (FlxG.keys.ONE)
            {
                FlxG.state = new CheatState();
            }
            if (FlxG.keys.TWO)
            {
                FlxG.state = new CaveState();
            }
            if (FlxG.keys.THREE)
            {
                FlxG.state = new RaceOrDieState();
            }
            if (FlxG.keys.FOUR)
            {
                FlxG.state = new TweenerState();
            }
            if (FlxG.keys.FIVE)
            {
                FlxG.state = new RobotFootballState();
            }
            if (FlxG.keys.SIX)
            {
                FlxG.state = new AnimationCallbackState();
            }
            if (FlxG.keys.SEVEN)
            {
                FlxG.state = new FlxPathState();
            }
			#if WINDOWS
            if (FlxG.keys.EIGHT)
            {
                FlxG.state = new PhysicsState();
            }

            if (FlxG.keys.NINE)
            {
                FlxG.state = new AngleAndVelocityState();
            }
            if (FlxG.keys.F2)
            {
                FlxG.state = new Physics2State();
            }
            if (FlxG.keys.F3)
            {
                FlxG.state = new IslandState();
            }
            if (FlxG.keys.F4)
            {
                FlxG.state = new Island2State();
            }
            if (FlxG.keys.F5)
            {
                FlxG.state = new Physics3State();
            }
			#endif
            if (FlxG.keys.F6)
            {
                FlxG.state = new FlxBarState();
            }
            if (FlxG.keys.F7)
            {
                FlxG.state = new ScrollingTest();
            }
			#endif

            base.update();
        }


    }
}
