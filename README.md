# CounterstrikeSharp - Throwing Knifes

[![UpdateManager Compatible](https://img.shields.io/badge/CS2-UpdateManager-darkgreen)](https://github.com/Kandru/cs2-update-manager/)
[![GitHub release](https://img.shields.io/github/release/Kandru/cs2-throwing-knifes?include_prereleases=&sort=semver&color=blue)](https://github.com/Kandru/cs2-throwing-knifes/releases/)
[![License](https://img.shields.io/badge/License-GPLv3-blue)](#license)
[![issues - cs2-throwing-knifes](https://img.shields.io/github/issues/Kandru/cs2-throwing-knifes)](https://github.com/Kandru/cs2-throwing-knifes/issues)
[![](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/donate/?hosted_button_id=C2AVYKGVP9TRG)

This is a simple throwing knife plug-in. Allow players to throw their knife(s).

## Installation

1. Download and extract the latest release from the [GitHub releases page](https://github.com/Kandru/cs2-throwing-knifes/releases/).
2. Move the "ThrowingKnifes" folder to the `/addons/counterstrikesharp/plugins/` directory.
3. (Re)start the server and wait for it to be completely loaded.
4. Restart the server again because it maybe applied some Gamedata entries for the plug-in to work correctly.

Updating is even easier: simply overwrite all plugin files and they will be reloaded automatically. To automate updates please use our [CS2 Update Manager](https://github.com/Kandru/cs2-update-manager/).


## Configuration

This plugin automatically creates a readable JSON configuration file. This configuration file can be found in `/addons/counterstrikesharp/configs/plugins/ThrowingKnifes/ThrowingKnifes.json`.

```json
{
  "enabled": true,
  "debug": false,
  "permissions": {
    "@css/root": {
      "amount_knifes": 5
    }
  },
  "permissions_is_whitelist": false,
  "amount_knifes": 2,
  "ConfigVersion": 1
}
```

### enabled

Whether this plug-in is enabled or not.

### debug

Debug mode. Only necessary during development or testing.

### permissions

Allows to add different permissions with different amount of weapons for players in this group. Only checks until first occurence for a player is found.

### permissions_is_whitelist

Whether or not a player must have the correct permission to use throwing knifes.

### amount_knifes

Maximum number of throwing knifes.

## Commands

### throwingknifes (Server Console Only)

Ability to run sub-commands:

```
throwingknifes reload
throwingknifes disable
throwingknifes enable
```

#### update

This reloads the configuration from the disk.

#### reload

Reloads the configuration.

#### disable

Disables the plug-in instantly and remembers this state.

#### enable

Enables the plug-in instantly and remembers this state.

## Compile Yourself

Clone the project:

```bash
git clone https://github.com/Kandru/cs2-throwing-knifes.git
```

Go to the project directory

```bash
  cd cs2-throwing-knifes
```

Install dependencies

```bash
  dotnet restore
```

Build debug files (to use on a development game server)

```bash
  dotnet build
```

Build release files (to use on a production game server)

```bash
  dotnet publish
```

## FAQ

TBD

## License

Released under [GPLv3](/LICENSE) by [@Kandru](https://github.com/Kandru).

## Authors

- [@derkalle4](https://www.github.com/derkalle4)
