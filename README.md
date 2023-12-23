# ClipboardHelper
<b>*ClipboardHelper*</b>  is a tool designed to increment a specific part of text from the clipboard directly. It helps break down the monotony of copying and pasting while manually incrementing a number.

# Downloads
<b>*Last release*</b> [v0.3.0-alpha](https://github.com/BenSabry/SynologyMediaHelper/releases/tag/v0.3.0-alpha)<br />
<b>*All releases*</b> [releases](https://github.com/BenSabry/SynologyMediaHelper/releases)

# Story
One day I was on call with my friend while he was editing some videos for his project. He asked if there was a way that would facilitate the manual copying and pasting of the same text while incrementing with every action. Since some of his videos are video game guides, which consist of a lot of incrementing, he suggested if there was a possible way to increment directly from the clipboard to cut the monotony of his process.

I did some research and concluded that there was a way to do so quite easily (at least for me), and hence my tool was born.

With a mix of my tool and maybe some macros, the editing process is much faster and less monotonous.

# Recommendations
a. <b>*BACKUP*</b> your media files first (you may use <b>*Synology Snapshot Replication*</b>)<br />
b. Connect your PC to <b>*SynologyNAS*</b> using Cable not WIFI for best performance<br />
c. Increase the <b>*TasksCount*</b> in <b>*[AppSettings.json](#AppSettings)*</b> (recommended: 2, best: <b>*CPU Cores*</b> count)<br />

# How to use
1. From your Windows PC open photos library directory on <b>*Synology*</b> from <b>*Windows Network (SMB)*</b><br />
2. Add the path of your library to <b>*Sources*</b> in <b>*[AppSettings.json](#AppSettings)*</b> file<br />
3. run the executable <b>*SynologyMediaHelper.exe*</b> and wait<br />

# How it works
1. Scan library files and directories added to <b>*Sources*</b> in <b>*[AppSettings.json](#AppSettings)*</b><br />
2. Check if the file already has <b>*CreationDate*</b><br />
&nbsp;&nbsp;&nbsp;2.1. if so: Move the file to proper directory <b>*MediaLibrary\Year\Month\File.*</b><br />
&nbsp;&nbsp;&nbsp;2.2. else:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.1. Extract date from filename if any and all dates from file info and choose the oldest<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.2. Update the file info <b>*CreationDate*</b> (after creating temp file as Backup)<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.3. Attempt to fix file info (like duplications/incorrect offsets ...etc)<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.4. Move the file to proper directory <b>*MediaLibrary\Year\Month\File.*</b><br /><br />
3. Clear temp files (which created as backup incase App/Windows closed improperly)<br />
4. Delete empty directories<br /><br />

Now just wait and your <b>*Synology*</b> will reindex media files and reorder them again based on updated info

# Fixable Issues
[<b>*Synology Photos: Not Using Taken Date*</b>](https://www.reddit.com/r/synology/comments/kgy604/synology_photos_not_using_taken_date/)<br />
[<b>*Synology Photos: organizes everything by modified date instead of creation date*</b>](https://www.reddit.com/r/synology/comments/120jsvk/synology_photos_organizes_everything_by_modified/)<br />
[<b>*Synology Photos: Indexing photos/videos with wrong date*</b>](https://www.reddit.com/r/synology/comments/qj9wya/synology_photos_indexing_photosvideos_with_wrong/)<br />
[<b>*Synology Photos: Best practice for photos with no taken date*</b>](https://www.reddit.com/r/synology/comments/rn5cvm/best_practice_for_photos_with_no_taken_date/)<br />

# Tech/Tools used
<b>*DotNET*</b>: is the free, open-source, cross-platform framework for building modern apps and powerful cloud services.<br />
<b>*ExifTool*</b>: is a customizable set of Perl modules plus a full-featured command-line application for reading and writing meta information in a wide variety of files.<br />

# AppSettings
<b>*TasksCount*</b>: (number) of <b>*Tasks/Threads*</b> to work simultaneously.<br />
<b>*EnableResume*</b>: (flag) to continue from the same point at which you previously stopped.<br />
<b>*EnableLog*</b>: (flag) to log actions to log.txt files found in <b>*.\Temp\Log.*</b><br />
<b>*AttemptToFixMediaIncorrectOffsets*</b>: (flag) to fix file info (like duplications/incorrect offsets ...etc)<br />
<b>*ClearBackupFilesOnComplete*</b>: (flag) Clear temp files on complete.<br />
<b>*DeleteEmptyDirectoriesOnComplete*</b>: (flag) Delete empty directories on complete.<br />
<b>*Sources*</b>: (array) paths of libraries or files which will be scanned<br />
<br />
<b>*Example:*</b><br />
{<br />
&nbsp;&nbsp;"TasksCount": 2,<br />
&nbsp;&nbsp;"EnableResume":  true,<br />
&nbsp;&nbsp;"EnableLog": true,<br />
&nbsp;&nbsp;"AttemptToFixMediaIncorrectOffsets": true,<br />
&nbsp;&nbsp;"ClearBackupFilesOnComplete": true,<br />
&nbsp;&nbsp;"DeleteEmptyDirectoriesOnComplete": true,<br />
&nbsp;&nbsp;"Sources": [<br />
&nbsp;&nbsp;&nbsp;&nbsp;"\\\\SynologyNAS\\home\\Photos\\MobileBackup",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"\\\\SynologyNAS\\home\\Photos\\PhotoLibrary",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"\\\\SynologyNAS\\home\\GraduationPhoto.jpg",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"\\\\SynologyNAS\\home\\GraduationVideo.mp4",<br />
&nbsp;&nbsp;]<br />
}<br />
