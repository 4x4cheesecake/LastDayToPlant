# Release History
Check out the [roadmap](https://github.com/dmcrider/LastDayToPlant/projects/1). Don't see a feature you want? [Create an issue](https://github.com/dmcrider/LastDayToPlant/issues/new)

v1.2.0 - Automatically check for Agriculturist skill (determined by the main player in multiplayer). Added flag for base crops in preparation for mod compatibility (coming soon)

v1.1.0 - Added configuration settings. Will now show messages when it is the last day to use each type of Speed Gro

v1.0.0 - Initial Release

# Install
- Download from [NexusMods](https://www.nexusmods.com/stardewvalley/mods/7917) (recommended) or from the [latest release](/dmcrider/LastDayToPlant/releases/latest)
- Requires SMAPI
- Extract the ZIP to `\Stardew Valley\Mods\`
- Start the game to create the `config.json` file

# Configuration
The configuration options work like this: In addition to a notification on Day 16 of Spring for Cauliflower, if you enable all options, you will also get a notification on Days 18, 19, and 20 for Speed Gro, Deluxe Speed Gro, and Hyper Speed Gro, respectively, for Cauliflower. As another example, you could also set `ShowBaseCrops` to `false` and set `ShowSpeedGro` to `true` to only recieve notifications on the last day that Speed Gro can be used.

The `config.json` file looks like this:

    {
      "ShowBaseCrops": true,
      "ShowSpeedGro": false,
      "ShowDeluxeSpeedGro": false,
      "ShowHyperSpeedGro": false
    }

The `IsAgriculturist` flag that was present in previous versions has been removed and is now automatically determined (based on the main player, if in multiplayer).

# Running into issues?
If something is going wrong, please let me know by [submitting an issue on GitHub](https://github.com/dmcrider/LastDayToPlant/issues/new), or email me directly at [mods@dayloncrider.com](mailto:mods@dayloncrider.com). I try my best to test multiple scenarios, but I can't test everything.

Want early access? Have a desire to help test releases before they go public? Send me an email at [mods@dayloncrider.com](mailto:mods@dayloncrider.com).

# Supported Languages
- English
- Spanish
- Brazilian Portuguese
- French (In Progress)

# Special Thanks
[@Duckexza](https://github.com/Duckexza) - Brazilian translation

# Like what I do?
If you enjoy the content I create, a donation is greatly appreciated (though NEVER required!). You can make a donation [on my website](https://www.dayloncrider.com/donations)
