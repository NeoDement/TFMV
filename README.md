# TFMV Neo 0.61
Team Fortress 2 Model Viewer

DOWNLOAD HERE: https://github.com/NeoDement/TFMV/releases

-------------------------------------------------------------------------------------------------------------------------------------------------------

PATCH NOTES:

-------------------------------------------------------------------------------------------------------------------------------------------------------

0.61 (01/09/2023)
_______________________________________________________________________________________________________________________


-Fixed left-over debug message popping up when changing bodygroup checkboxes (thanks Papyesh!)

MISSED NOTES FROM PREVIOUS RELEASE:

-Disabled an unnecessary automatic fix to Workshop zip files, as advised by Neodos.

-Fixed some grammar/typos.

_______________________________________________________________________________________________________________________

0.6 (01/08/2023)
_______________________________________________________________________________________________________________________

BODYGROUP FIXES:

-Fixed the Gunslinger not showing up as a valid item.

-Fixed the Gentle Manne's Service Medal not showing up as a valid item.

-Fixed the Purity Fist not loading the metallic fingers bodygroup.

-Fixed the Sydney Sleeper not loading the darts bodygroup.

-Fixed all tf_weapon_compound_bow weapons (Huntsman, Fortified Compound etc) not loading the arrows bodygroup.

-Fixed the Short Circuit not hiding the rightarm bodygroup.

TURNTABLE GENERATOR IMPROVEMENTS:

-Added an option to output as an image sequence instead of an animated GIF, so you can compress it yourself.
(in a future update, there will hopefully be some better GIF compression options)

-Reworked settings.

ITEM LIST IMPROVEMENTS:

-Improved search functionality. The displayed name is now searched instead of only the internal name, which should make it behave more like expected.

-You can now right click an item to copy its model path or search it on the Wiki. Removed the original Wiki button.

-Fixed wrong item names being taken from TF_English occasionally (POMSON instead of Pomson 5000, Fishcake Fragment instead of Fishcake etc).

-Fixed Workshop tab occasionally stopping part way through the loading process, when encountering a corrupt zip.

-Added option to download additional medals. These medals will show up under their own Medal item filter type.
(This only shows medals with unique models, duplicates are currently skipped for performance reasons.)

OTHER IMPROVEMENTS:

-Added options to choose which Class and Slot (ie Primary, Cosmetic) are selected on startup.

-Added style name and copyable model path to Skins tab.

-You no longer need to provide your own Steam API Key. If the built-in Key fails, you will be given the option to provide your own one.
(if you want to provide your own one anyway, save a txt document containing your Key in "api_key.ini" in the "TFMV/config" directory)

-Many other minor improvements.

-------------------------------------------------------------------------------------------------------------------------------------------------------

0.5 (10/19/2022)
   
-------------------------------------------------------------------------------------------------------------------------------------------------------

-Fixed items from Workshop zips showing as error models when disable jigglebones is unchecked and the files don't exist locally (thanks Tabby!)

-Fixed camera position, camera rotation and light rotation not accepting negative numbers (thanks Lo-fi!)

-Fixed window size and screenshot delay accepting invalid decimal numbers.

-Reorganized the order of paints to match the TF2 Wiki. This should make uploading painted images of in-game items easier (thanks Lo-fi!)

-Added button to view the TFMV Neo Github to About tab.

-------------------------------------------------------------------------------------------------------------------------------------------------------

0.4 (10/18/2022)
   
-------------------------------------------------------------------------------------------------------------------------------------------------------

-Fixed a bug preventing HLMV from starting up relating to the HLMV recent files list change from 0.1 (thanks Wurlmon!)

-Updated exe assembly information (TFMV Neo 0.3 was mistakenly referred to as TFMV 1.9 - Community Edition).

-------------------------------------------------------------------------------------------------------------------------------------------------------

0.3 (10/18/2022)
   
-------------------------------------------------------------------------------------------------------------------------------------------------------

NEW FEATURES:

-Added a checkbox to disable jiggle bones on loaded items.

-Added Taunt Prop item filter type. This means you can load any ingame taunt prop alongside regular items.

-Added option to expand item list on startup.

-Added option to replace default Valve cubemap with one from 2fort. This feature will be expanded upon in the next release.


IMPROVEMENTS:

-Updated "Save current as default" button to also save Light and Background color settings.

-Added options to disable TFMV overrides for Light and Window settings.

-Added reset buttons to Background and Window settings.

-Improved fixed head texture mipmap functionality. Now TFMV fixes them automatically instead of storing uncompressed versions of the head textures.

-Made some non-tournament medals visible in the item selection panel. Notably, this prevents the Made Man not appearing in Spy's list of cosmetic items.

(the Gentle Manne's Service Medal, Employee Badges and Dueling Badges are still disabled for now)

OTHER CHANGES:

-Fixed a bug preventing the TFMV folder in the Custom folder from being deleted when closing TFMV.

-Removed PDA2 item filter type. It didn't work properly and both PDA2 items in the game are duplicates of existing items. The Taunt Prop filter replaces it.

-Changed default HLMV window size to 800x600.

-Added warning/instructions when a user attempts to load a Voodoo-Cursed Zombie Soul.

-Added "Latest Patch Notes" to About tab.

-------------------------------------------------------------------------------------------------------------------------------------------------------

0.2 (05/08/2022)
   
-------------------------------------------------------------------------------------------------------------------------------------------------------

-TFMV now asks for an API Key the first time you launch it, so you're no longer relying on a key that could be invalidated at some point in the future.


-------------------------------------------------------------------------------------------------------------------------------------------------------

0.1 (05/06/2022)
   
-------------------------------------------------------------------------------------------------------------------------------------------------------

-TFMV now auto-installs fixed head textures into the custom folder when putting a loadout into HLMV (no more pixelated eyebrows!)

-TFMV no longer deletes the HLMV recent files list (good for those of us that still launch HLMV the old fashioned way sometimes).

-------------------------------------------------------------------------------------------------------------------------------------------------------


User Guide / More information: https://steamcommunity.com/sharedfiles/filedetails/?id=158547475

TFMV is a program that adds functionality and automation to the Source Engine HLMV.exe model viewer (of Team Fortress 2).

TFMV (Team Fortress Model Viewer) is a tool for Windows that makes it easier to load and preview TF2 player item loadouts in the model viewer "HLMV" 
and also helps for testing and developing workshop items by automating file loading and adding features on top of HLMV for tasks which are otherwise 
impossible or require tedious manual file managing and editing.

The tool also lists the TF2 items so you can easily pick and load items by their icon instead of having to search and pick the models by file name.
TFMV downloads the items list and icons from the official servers, so it's always up to date and the latest items can be loaded.

TFMV manages the models and materials(aka skins) of each item through a visual interface, rather than having search, load or edit files and dependencies manually.
It also makes it possible to switch skins(red/blue) on model attachments, change paint colors, easily edit skins with the material editor and test material 
changes in real time, take screenshots with specific resolutions, take screenshots with transparency, automatically capture screenshots for each of item's paint color, 
load workshop .zip compiled items, etc
