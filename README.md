# ClipboardHelper
<b>*ClipboardHelper*</b> is a software tool engineered to modify a particular segment of text. It’s designed to alleviate the tediousness of copying and pasting while manually altering a specific part of the text, such as repeatedly pasting the same text while manually increasing a number in the text each time.<br />

# Downloads
<b>*Latest release*</b> [v0.2.0-alpha](https://github.com/BenSabry/ClipboardHelper/releases/tag/v0.2.0-alpha)
<b>*All releases*</b> [releases](https://github.com/BenSabry/ClipboardHelper/releases)

# Story
One day, while on a call with a friend who was editing videos for his project, he inquired if there was a method that could simplify the manual process of copying and pasting the same text while incrementing with each action. Given that many of his videos are video game guides, which involve a lot of incrementing, he wondered if there was a way to increment directly from the clipboard to reduce the repetitiveness of his process.<br /><br />

After conducting some research, I determined that there was a relatively straightforward way to accomplish this (at least for me), and thus my tool was created.<br />
By combining my tool with potentially some macros, the editing process has become much quicker and less repetitive.<br />

# How to use
1. Launch <b>*ClipboardHelper*</b> and enter the text you wish to modify.<br />
2. Substitute the keywords you want to use in place of the actual value.<br />
3. Now, navigate to the location where you want to paste the newly computed text and press the Shortcut to paste.<br />
4. Use the <b>*Reset*</b> button to revert to default values or Pause to halt the program.<br />

# How it works
Each time you paste, the program will look for special keywords included to compute it, such as {INCREMENT} to increment a numeric value, etc.

# Fixable Issues
[<b>*Increment number in Textbox via macro*</b>](https://www.reddit.com/r/davinciresolve/comments/163mep5/possible_to_increment_number_in_text_box_via_macro/)<br />
[<b>*Auto increment Clipboard's number value*</b>](https://www.autohotkey.com/board/topic/78191-auto-increment-clipboards-number-value/)<br />

# Tech/Tools used
<b>*.NET*</b>: is the free, open-source, cross-platform framework for building modern apps and powerful cloud services.<br />
