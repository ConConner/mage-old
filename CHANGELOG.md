# [1.21.0](https://github.com/ConConner/MAGE-Themes/compare/v1.20.0...v1.21.0) (2026-09-15)


### Bug Fixes

* keyboard shortcuts get triggered when writing in textboxes ([9bef272](https://github.com/ConConner/MAGE-Themes/commit/9bef272fec3b0bcfe1b376b9df53d08d72daf6f2))


### Features

* optionally allow sprite IDs up to 0xFF in spriteset editor ([f218285](https://github.com/ConConner/MAGE-Themes/commit/f2182857109a3e4aa9023ee64e3534806200ae01)), closes [#88](https://github.com/ConConner/MAGE-Themes/issues/88)
* test room settings for fusion ([5b9d49a](https://github.com/ConConner/MAGE-Themes/commit/5b9d49a2140aba1f1c16ceace51230239e04df28)), closes [#96](https://github.com/ConConner/MAGE-Themes/issues/96)
* warning system for incorrectly used clipdata ([459bf74](https://github.com/ConConner/MAGE-Themes/commit/459bf74678127c72be9bc50907efe85ee6162b88))

# [1.20.0](https://github.com/ConConner/MAGE-Themes/compare/v1.19.1...v1.20.0) (2026-08-30)


### Bug Fixes

* project file config persists when switching to a ROM without project file ([b83afd3](https://github.com/ConConner/MAGE-Themes/commit/b83afd3dee59445a44492d864832e1ac88db9509))
* room options resize always displays screen amount as decimal ([60d5445](https://github.com/ConConner/MAGE-Themes/commit/60d5445ce0b4c7dc991b1ffb2ff89e1190cade64))


### Features

* cut and delete functionality in graphics editor [experimental] ([fb4d66c](https://github.com/ConConner/MAGE-Themes/commit/fb4d66ce5a8df10f42b56407496483eb69e64c31))
* New Palette Editor [experimental] ([019322e](https://github.com/ConConner/MAGE-Themes/commit/019322ed033aa7c3965509fb6f726d9ca2be91ca)), closes [#66](https://github.com/ConConner/MAGE-Themes/issues/66)

## [1.19.1](https://github.com/ConConner/MAGE-Themes/compare/v1.19.0...v1.19.1) (2026-08-02)


### Bug Fixes

* flipping in graphics editor while moving a selection does not flip the selection ([79522aa](https://github.com/ConConner/MAGE-Themes/commit/79522aaae5c776f22d6df0c43b91089383fccb0e))

# [1.19.0](https://github.com/ConConner/MAGE-Themes/compare/v1.18.0...v1.19.0) (2026-08-02)


### Bug Fixes

* mage crashes if any offset input box looses focus while containing an invalid HEX-number ([32bcee8](https://github.com/ConConner/MAGE-Themes/commit/32bcee8e775fb79a16c6d7c9e8b616b00afd5323))


### Features

* added copy & paste functionality to graphics editor [experimental] ([fc2161b](https://github.com/ConConner/MAGE-Themes/commit/fc2161b9550a5a932f0eae70e84e8c5dea08ad4a))
* added flip to graphics editor [experimental] ([b5fb592](https://github.com/ConConner/MAGE-Themes/commit/b5fb59221e0d0d9c22bbe4cb5b33a34a45ffb4a0)), closes [#95](https://github.com/ConConner/MAGE-Themes/issues/95)
* hold shift to snap to grid in graphics editor [experimental] ([e42ef47](https://github.com/ConConner/MAGE-Themes/commit/e42ef47b7e8db988a33eb29b39f235772161f7e2))
* selections can be moved in graphics editor [experimental] ([8a25de4](https://github.com/ConConner/MAGE-Themes/commit/8a25de42aee5df9a9e95b43a25d108c4b1e3c4dd))

# [1.18.0](https://github.com/ConConner/MAGE-Themes/compare/v1.17.0...v1.18.0) (2026-07-31)


### Bug Fixes

* "save, undo then save again" does not save the undone changes in room editor ([b9bbace](https://github.com/ConConner/MAGE-Themes/commit/b9bbace849039963e577d3c5659b7211a245eab9))


### Features

* "add minimap tiles" patch removed. Minimap tiles can now be expanded in the map editor ([5fded4b](https://github.com/ConConner/MAGE-Themes/commit/5fded4b91c9b21e742f331197842043b31aa4457))
* add undo & redo buttons to map editor ([3dd54ee](https://github.com/ConConner/MAGE-Themes/commit/3dd54eead2254e7fa557a1aedfca330abf07483c))
* add undo & redo buttons to tile table editor ([d58dc8e](https://github.com/ConConner/MAGE-Themes/commit/d58dc8e26a3d6f5aceb17f69942da5398e9c7d43)), closes [#103](https://github.com/ConConner/MAGE-Themes/issues/103)
* collision outlines can be combined with either breakable or value view ([78f1940](https://github.com/ConConner/MAGE-Themes/commit/78f1940dbf2dee7543ecb8daea4c1e71de2a482b)), closes [#65](https://github.com/ConConner/MAGE-Themes/issues/65)
* press ctrl + A in map editor to select all map tiles from the map ([2a09baa](https://github.com/ConConner/MAGE-Themes/commit/2a09baa3cba38a3a6ebd24284a53a09b82ad9ebe))
* press ctrl + A in tile table editor to select all tiles from the table view ([54e72ef](https://github.com/ConConner/MAGE-Themes/commit/54e72ef84ccce30d2d3cccf3529ba1e7be0d0390)), closes [#94](https://github.com/ConConner/MAGE-Themes/issues/94)

# [1.17.0](https://github.com/ConConner/MAGE-Themes/compare/v1.16.0...v1.17.0) (2026-07-29)


### Bug Fixes

* mage crashes when flipping hidden map tiles in metroid fusion ([e884af7](https://github.com/ConConner/MAGE-Themes/commit/e884af7910b1ad00d5aa31c426f401876cf07595))
* NCalcSync version has vulnerability ([7b4ca3d](https://github.com/ConConner/MAGE-Themes/commit/7b4ca3d4b2e2d7b3293b12c6b0bb81aaa1f249d8))
* tweaks with toggle without a default value result in an error ([fc1f405](https://github.com/ConConner/MAGE-Themes/commit/fc1f405278c4fefcd328072dd46ac828fd979528)), closes [#104](https://github.com/ConConner/MAGE-Themes/issues/104)


### Features

* add a list of music names in preferences that will be displayed in header editor ([841609d](https://github.com/ConConner/MAGE-Themes/commit/841609d007e215dcfd8caa721aa76c396d63a213))
* added states input when adding new animated graphics or palettes ([1eeeb0d](https://github.com/ConConner/MAGE-Themes/commit/1eeeb0db3c44b209bde2f0d31855d086c374b2f2)), closes [#78](https://github.com/ConConner/MAGE-Themes/issues/78)

# [1.16.0](https://github.com/ConConner/MAGE-Themes/compare/v1.15.0...v1.16.0) (2026-05-11)


### Features

* moved new map editor out of experimental ([a223ec8](https://github.com/ConConner/MAGE-Themes/commit/a223ec8a1f6d4e86a2c5486d0e6fd1063f622728))

# [1.15.0](https://github.com/ConConner/MAGE-Themes/compare/v1.14.1...v1.15.0) (2026-05-11)


### Bug Fixes

* add edit palette button to experimental graphics editor ([0c4f459](https://github.com/ConConner/MAGE-Themes/commit/0c4f45932af912074b298670f2f848057ff6a340)), closes [#90](https://github.com/ConConner/MAGE-Themes/issues/90)
* hybrid compilation crashes if no lines are written to stdout ([5aed32d](https://github.com/ConConner/MAGE-Themes/commit/5aed32db9ffb48bf0b5b30faefe01b63e75bd95b))
* tile table import dialog opens on wrong button ([4dc854a](https://github.com/ConConner/MAGE-Themes/commit/4dc854a2f7923ba1bc38c22eda7a84915a88007a))


### Features

* [#82](https://github.com/ConConner/MAGE-Themes/issues/82) added transparency dialog and button to header editor. ([798dab0](https://github.com/ConConner/MAGE-Themes/commit/798dab08f9a826ef6379099be7a63f81ee40281c))
* added hexsanitized and hexsanitizedmaxvalue properties to customcontrols flattextbox ([aba257d](https://github.com/ConConner/MAGE-Themes/commit/aba257dcdb4eda320e4d26da8b897ac73ef6bb06))
* import oam as assembly ([6d45261](https://github.com/ConConner/MAGE-Themes/commit/6d452618c65b8e4caae703c0ed2958cefaf4aa17))
* select palette row for oam editor gfx preview ([90db9b1](https://github.com/ConConner/MAGE-Themes/commit/90db9b185e11072fcb7ee09cc049494237b568dd))

## [1.14.1](https://github.com/ConConner/MAGE-Themes/compare/v1.14.0...v1.14.1) (2026-03-12)


### Bug Fixes

* OAM export as assembly missing "OAM_" prefix ([8bba2f8](https://github.com/ConConner/MAGE-Themes/commit/8bba2f83f613a561fb71d1a9942531aee862f046))

# [1.14.0](https://github.com/ConConner/MAGE-Themes/compare/v1.13.0...v1.14.0) (2026-02-27)


### Bug Fixes

* door-id-overlays do not respect number base preference ([79a710c](https://github.com/ConConner/MAGE-Themes/commit/79a710c86619fbaaccc28c6b55383620e999e33c)), closes [#58](https://github.com/ConConner/MAGE-Themes/issues/58)
* list view control is not themed correctly ([f021ebe](https://github.com/ConConner/MAGE-Themes/commit/f021ebeade2f6e1c9ec233cb440f5351aec55ff2))
* some editor shortcuts do not respect the editor choice preference ([d15c989](https://github.com/ConConner/MAGE-Themes/commit/d15c9891f839c3cd089ddccdcc6e7530a9b3da1e))
* switching roms leads to multiple backups being created during auto-backup ([9d5553c](https://github.com/ConConner/MAGE-Themes/commit/9d5553c5db1862921b063c18b390258df63c571b)), closes [#33](https://github.com/ConConner/MAGE-Themes/issues/33)
* testing a room sometimes selects tourian in the area selector ([8217711](https://github.com/ConConner/MAGE-Themes/commit/8217711a1c498adfd43e4bab31f39a702850d842)), closes [#47](https://github.com/ConConner/MAGE-Themes/issues/47)
* tile table editor might resize lz77 bg to 256x256 ([5594c6d](https://github.com/ConConner/MAGE-Themes/commit/5594c6d93a181594458852509bda2b9a13fccba0)), closes [#37](https://github.com/ConConner/MAGE-Themes/issues/37)
* tiles cannot be placed in TTE when shift is applied ([fa96af1](https://github.com/ConConner/MAGE-Themes/commit/fa96af12436c6f2d31527758e64fb5d1bb799567)), closes [#69](https://github.com/ConConner/MAGE-Themes/issues/69)


### Features

* added tweak manager ([4efa88e](https://github.com/ConConner/MAGE-Themes/commit/4efa88e80c0ed4adead46692cf53917163cdb123))
* export area as pixel image ([6fcb518](https://github.com/ConConner/MAGE-Themes/commit/6fcb5188d35a87eb2814c760c1937a730482d575)), closes [#80](https://github.com/ConConner/MAGE-Themes/issues/80)
* export room as pixel image ([48d9da0](https://github.com/ConConner/MAGE-Themes/commit/48d9da0000e55059df03f65d52d22dce70bf145c))
* export tile table as image ([a35f970](https://github.com/ConConner/MAGE-Themes/commit/a35f9707c9b3cff8c0bdc7d4d50ec861949e4050))

# [1.13.0](https://github.com/ConConner/MAGE-Themes/compare/v1.12.4...v1.13.0) (2026-02-16)


### Features

* hybrid rom compilation ([5621751](https://github.com/ConConner/MAGE-Themes/commit/5621751b2eda16ef444a1f75bb0cb1bbd8a36bb1))
* test rom with hybrid rom compilation ([5083dac](https://github.com/ConConner/MAGE-Themes/commit/5083dacc27d8b8e5baa6bbdc1c3944199eb23519))

## [1.12.4](https://github.com/ConConner/MAGE-Themes/compare/v1.12.3...v1.12.4) (2026-01-29)


### Bug Fixes

* OAM assembly export is missing colon and should use static labels ([afce28c](https://github.com/ConConner/MAGE-Themes/commit/afce28c5819fcf4e1572781c360615861a830fa4))

## [1.12.3](https://github.com/ConConner/MAGE-Themes/compare/v1.12.2...v1.12.3) (2026-01-25)


### Bug Fixes

* clipdata cannot be placed without a tile selection ([c8c4ec9](https://github.com/ConConner/MAGE-Themes/commit/c8c4ec93fe7263068f7d84c3540d3581f3b192b0)), closes [#68](https://github.com/ConConner/MAGE-Themes/issues/68)

## [1.12.2](https://github.com/ConConner/MAGE-Themes/compare/v1.12.1...v1.12.2) (2026-01-25)


### Bug Fixes

* large area image exports can crash the program ([0ae6e4a](https://github.com/ConConner/MAGE-Themes/commit/0ae6e4af4637d07d803637f0edff558b3995bf19))

## [1.12.1](https://github.com/ConConner/MAGE-Themes/compare/v1.12.0...v1.12.1) (2026-01-13)


### Bug Fixes

* picking a color in unused graphics editor space crashes the program ([cb3d723](https://github.com/ConConner/MAGE-Themes/commit/cb3d723ed25a978a0a2797c493bb4630205b801b))

# [1.12.0](https://github.com/ConConner/MAGE-Themes/compare/v1.11.1...v1.12.0) (2026-01-13)


### Bug Fixes

* map editor does not discard changes after manually saving and swapping maps ([876628b](https://github.com/ConConner/MAGE-Themes/commit/876628b756fe184e0bfc2cbdc94d1bdc0a4230e3))


### Features

* added button to edit graphics in tile table editor ([f0f3533](https://github.com/ConConner/MAGE-Themes/commit/f0f3533d3cbf9d51860ba2fb5bcf13225f6dc178))
* new graphics editor [experimental] ([284b26e](https://github.com/ConConner/MAGE-Themes/commit/284b26e0824ff9ccf2594ecdd20e740d5a1de381))
* room editor selection is animated (might be removed again later) ([54c59a6](https://github.com/ConConner/MAGE-Themes/commit/54c59a6157ec4e96b111cfb5cffc80aa1e18641c))
* select multiple rooms to exclude at once in area export ([8ecbd43](https://github.com/ConConner/MAGE-Themes/commit/8ecbd4362b958521c46fb6d0bef4d3f965c5c0f9))

## [1.11.1](https://github.com/ConConner/MAGE-Themes/compare/v1.11.0...v1.11.1) (2026-01-03)


### Bug Fixes

* bookmarks become uneditable when opening bookmark window without prior bookmark selection ([6a51150](https://github.com/ConConner/MAGE-Themes/commit/6a51150a5a40e831cc08deedb3b46b3ca98556db))
* map editor is missing button to edit map graphics ([d20ec30](https://github.com/ConConner/MAGE-Themes/commit/d20ec3028269eb9b26322be84f7c2f3abc221544))
* map editor is missing selected tile-id display ([fd9d4a8](https://github.com/ConConner/MAGE-Themes/commit/fd9d4a8a2b9d6c8117c4616a87b818407a03ed76))
* map editor is missing unexplored (visual) map type for metroid fusion ([2becb87](https://github.com/ConConner/MAGE-Themes/commit/2becb879030ba7b4ed7b5b973b16cb5acfecea02))

# [1.11.0](https://github.com/ConConner/MAGE-Themes/compare/v1.10.0...v1.11.0) (2025-12-12)


### Bug Fixes

* importing a tileset with a different height may squash the tile view until resize ([7ce6425](https://github.com/ConConner/MAGE-Themes/commit/7ce6425536520022fcee1f127ad98cf6ac7f8d85))
* map editor does sometimes not discard changes when swapping maps ([fb7b2b9](https://github.com/ConConner/MAGE-Themes/commit/fb7b2b9398946c200fc70bbc8f5e59556cf8c596))
* project bookmarks cannot be properly renamed ([d1c10d9](https://github.com/ConConner/MAGE-Themes/commit/d1c10d91728fee687751fbe985d2b1c9762875a3))
* values cannot be set for global bookmarks ([354e237](https://github.com/ConConner/MAGE-Themes/commit/354e2376bd78e408533b485e70d60c0f75dbea66))


### Features

* added new controls to bookmarks to reduce context menu usage ([c65275d](https://github.com/ConConner/MAGE-Themes/commit/c65275d6762e1471a3aa2ded4f14666f6c3b73b2))
* upgrade to .NET version 10 ([9b1a4c4](https://github.com/ConConner/MAGE-Themes/commit/9b1a4c4773c52e4e38c968375cadea4bc8333044))

# [1.10.0](https://github.com/ConConner/MAGE-Themes/compare/v1.9.2...v1.10.0) (2025-10-12)


### Features

* backup name format can be specified ([51da9b6](https://github.com/ConConner/MAGE-Themes/commit/51da9b61c44041eed40df5e48a986f20cba83fbf))
* backups can be saved under a ./backups/ directory ([b086e1f](https://github.com/ConConner/MAGE-Themes/commit/b086e1f2b4562743b81f6d837fc9a8711becce4e))
* backups can be set to be created periodically ([233eb28](https://github.com/ConConner/MAGE-Themes/commit/233eb2828bd19bb7e35b25d89f6b75028be62503))

## [1.9.2](https://github.com/ConConner/MAGE-Themes/compare/v1.9.1...v1.9.2) (2025-09-30)


### Bug Fixes

* color behind bg3 option does not display the current color after reload ([c83fb1f](https://github.com/ConConner/MAGE-Themes/commit/c83fb1fde05069578fd40770786e6fb5c4983d03))

## [1.9.1](https://github.com/ConConner/MAGE-Themes/compare/v1.9.0...v1.9.1) (2025-09-28)


### Bug Fixes

* accent contrast color would sometimes result in illegible text ([f37bc0c](https://github.com/ConConner/MAGE-Themes/commit/f37bc0c9f81a41a3a39291b2382234f1586aaf6c))
* changing a theme directly after opening the preferences menu sets every color to the background color ([7b705b3](https://github.com/ConConner/MAGE-Themes/commit/7b705b3b732e3dd4501a25cc9a87134efd80a10a))
* changing themes in room editor changes the background color of the tileset view ([e898a15](https://github.com/ConConner/MAGE-Themes/commit/e898a153d0af52854c85c3ddd0b7d56f3f8433d2))
* credits editor crashes if no text is commited in an edit ([31b90ca](https://github.com/ConConner/MAGE-Themes/commit/31b90caf32e0cd07bc8405e147653238078170d7))
* credits editor documentation missing ([9a1cebf](https://github.com/ConConner/MAGE-Themes/commit/9a1cebfbc249ead9d1f9d533ddb4647eef2c179e))
* help viewer does not follow links to internal documentation correctly ([497e819](https://github.com/ConConner/MAGE-Themes/commit/497e81934f511c887da7ff6be510343c368bf371))
* help viewer theming results in illegible headers ([e3b2342](https://github.com/ConConner/MAGE-Themes/commit/e3b23423e796500ba04a9f417dccc25167460376))

# [1.9.0](https://github.com/ConConner/MAGE-Themes/compare/v1.8.0...v1.9.0) (2025-09-26)


### Bug Fixes

* buttons on the "new update available" form do not scale correctly ([cd58920](https://github.com/ConConner/MAGE-Themes/commit/cd5892011862fec1ce8ee32bd3a61046b499ea95))
* demo test does not respect TestRom path ([8e953d6](https://github.com/ConConner/MAGE-Themes/commit/8e953d6e44e39138cc28d3b9f98e226aef9641f8))


### Features

* add unsaved changes check to sprite editor ([840ac9b](https://github.com/ConConner/MAGE-Themes/commit/840ac9b1678608db6796b821b5da29b451aa8d15))
* added credits editor ([d8d0766](https://github.com/ConConner/MAGE-Themes/commit/d8d0766af8a88fc675a3033d2db003526e028c9f))
* added outlines to the tilesets in the tileset dialog ([374936c](https://github.com/ConConner/MAGE-Themes/commit/374936cee794d71332066a50d4ee3557b23588e1))
* import and export credits compatible with ConCons Credits Crediter ([7cbf53d](https://github.com/ConConner/MAGE-Themes/commit/7cbf53d2c18f786db129ecbbf72271f5040129d8))
* modify freezing resistance for ZM in the sprite editor ([d070fdd](https://github.com/ConConner/MAGE-Themes/commit/d070fddabdb63f2a53382eb5c48e0a327c08edea))
* moved bookmarks button from "Options" to "Tools" ([0ae574b](https://github.com/ConConner/MAGE-Themes/commit/0ae574b6e537e06d4fc50d9fa9d5aca0a4af6158))
* update docs ([9963347](https://github.com/ConConner/MAGE-Themes/commit/99633470191bc32dbfb1a7ac609360d8cfdb26e5))

# [1.8.0](https://github.com/ConConner/MAGE-Themes/compare/v1.7.0...v1.8.0) (2025-09-18)


### Bug Fixes

* oam editor: palette loading can lead to an out of bounds error ([a405b58](https://github.com/ConConner/MAGE-Themes/commit/a405b58eaf691356bdf7dea58ea1c1a07b331bf4))


### Features

* display room outlines in the map editor [experimental] ([1851882](https://github.com/ConConner/MAGE-Themes/commit/185188293328b92f274cf0b8cacae9228b2c6adf))
* new map editor [experimental] ([24eec3a](https://github.com/ConConner/MAGE-Themes/commit/24eec3aaed57dd88bcfa71751a419eb0626794dc))
* renamed "Minimap Editor" to "Map Editor" ([4793e14](https://github.com/ConConner/MAGE-Themes/commit/4793e14c8c8c4974dab618fc2efa1045479568a4))
* renamed "Minimap Tile Builder" to "Map Tile Builder" ([f623761](https://github.com/ConConner/MAGE-Themes/commit/f62376138ab82cdfc9e94edb872885fe51985b54))
* resizeable panels display a handle ([462ab82](https://github.com/ConConner/MAGE-Themes/commit/462ab8238d9e7b464d0841c058222e24c58e62fb))
* room editor layout changes: tileset display can be resized ([9d42740](https://github.com/ConConner/MAGE-Themes/commit/9d42740dc39106cd25b39b923cb72d13a9316109))
* toggle usage of common sprite graphics in oam editor ([b090c0e](https://github.com/ConConner/MAGE-Themes/commit/b090c0efdbad7249f635733ac0cc76588ca5ab57))
* zoom in room editor tileset ([716145e](https://github.com/ConConner/MAGE-Themes/commit/716145e7949044a743574e8f9a9569f0175da040))

# [1.7.0](https://github.com/ConConner/MAGE-Themes/compare/v1.6.0...v1.7.0) (2025-09-14)


### Features

* add elevator shortcuts to clipdata shortcuts ([8d52a50](https://github.com/ConConner/MAGE-Themes/commit/8d52a5020c7675cfcf2883ed3e24ab99e1bc4432))
* added hatches to clipdata shortcuts ([7af22d5](https://github.com/ConConner/MAGE-Themes/commit/7af22d57f097f3012b99f3db5a097126ce6e546e))
* choose whether to check for updates ([dde1b4d](https://github.com/ConConner/MAGE-Themes/commit/dde1b4d31f436b2e08e334d615185597b32f6ab9))
* rearranged clipdata shortcuts ([d122c0b](https://github.com/ConConner/MAGE-Themes/commit/d122c0b3c361b477cef5bc7255f02eda1520857b))

# [1.6.0](https://github.com/ConConner/MAGE-Themes/compare/v1.5.1...v1.6.0) (2025-09-11)


### Bug Fixes

* values of internal bookmarks can't be highlighted with the mouse ([f775444](https://github.com/ConConner/MAGE-Themes/commit/f77544494c0df89c710ca44255bc2859dbaeb053))
* version string contains a trailing 0 in about page ([a169c7a](https://github.com/ConConner/MAGE-Themes/commit/a169c7abfe6023263f32de28e4883bbaf490d361))


### Features

* "save with ctrl+s" and more shortcuts added ([9d2e399](https://github.com/ConConner/MAGE-Themes/commit/9d2e399954802ac54053c516a96a107ec03742d8))
* add icons to the menu bar items ([3684e50](https://github.com/ConConner/MAGE-Themes/commit/3684e5040078227f5de1193a102eec26c3a73e49))
* add multiple emulators and choose between them ([437ee80](https://github.com/ConConner/MAGE-Themes/commit/437ee80c8971a2bbf61654ae66e3d16b1ff2b416))
* change Test-ROM path ([31eeca8](https://github.com/ConConner/MAGE-Themes/commit/31eeca8d54849c55480ac72ae9d4562fc229855b)), closes [#22](https://github.com/ConConner/MAGE-Themes/issues/22)
* choose to include symbol file with Test-ROM ([7fd0e8d](https://github.com/ConConner/MAGE-Themes/commit/7fd0e8db6451cebba6677f28798920b6835d17a2))
* new options menu ([88fcfca](https://github.com/ConConner/MAGE-Themes/commit/88fcfca9a6013f0ef50c52fa0d2700a480a5408b))

## [1.5.1](https://github.com/ConConner/MAGE-Themes/compare/v1.5.0...v1.5.1) (2025-08-23)


### Bug Fixes

* bookmarks do not get dropped off at the desired location ([6fc9b67](https://github.com/ConConner/MAGE-Themes/commit/6fc9b6786ee14dfa3df6183480c88da0d356027a))

# [1.5.0](https://github.com/ConConner/MAGE-Themes/compare/v1.4.0...v1.5.0) (2025-08-22)


### Bug Fixes

* oam editor now properly opens default OAM even if repointed ([e515853](https://github.com/ConConner/MAGE-Themes/commit/e515853c6b90193355e6e264cecc195b32730161))
* oam editor: removed unused menu bar ([6fb166c](https://github.com/ConConner/MAGE-Themes/commit/6fb166c55531843acb6c78b38df261f2eaa97cc5))
* OAM repointing now saves repointed sprites in the project file ([8deb2fa](https://github.com/ConConner/MAGE-Themes/commit/8deb2fa553d211b37cbc35bfb95b2203290349f1))
* outlines of text boxes behave correctly ([d70f8a6](https://github.com/ConConner/MAGE-Themes/commit/d70f8a66f0bb818a33ba521f7c5d383931c997e4))
* weapon editor: controls visually overlapping ([37fadda](https://github.com/ConConner/MAGE-Themes/commit/37fadda4a817f5739c695bb2c6c58654efb1a6b9))


### Features

* bookmarking feature, create bookmarks to store offsets ([f06a91a](https://github.com/ConConner/MAGE-Themes/commit/f06a91abbc2e5ccd5d24dd3176da934091767779))
* repointed resources get saved in bookmarks ([842f108](https://github.com/ConConner/MAGE-Themes/commit/842f108fcbff3372802eccaf176fdc03d7dcaeba))

# [1.4.0](https://github.com/ConConner/MAGE-Themes/compare/v1.3.0...v1.4.0) (2025-08-14)


### Bug Fixes

* oam editor no longer crashes after playing an animation and selecting a part ([5294e31](https://github.com/ConConner/MAGE-Themes/commit/5294e3123235af4c4a7d80a93e6ddbdbc3fba498))
* oam editor no longer crashes after removing a frame and saving ([fd9fc31](https://github.com/ConConner/MAGE-Themes/commit/fd9fc314317b21065992427455c70ae62f277ee2))


### Features

* export and import OAM from and to MAGE ([f85b9d1](https://github.com/ConConner/MAGE-Themes/commit/f85b9d1852784987cf47949bfcac2d0e8911968b))
* export OAM as animated .gif ([27b19d1](https://github.com/ConConner/MAGE-Themes/commit/27b19d152fdb42a195a37ed12596b4e2d8ce7361))
* export OAM as assembly ([27fcca7](https://github.com/ConConner/MAGE-Themes/commit/27fcca70fa01c1ec232ff8d712be4d487c0d4aac))

# [1.3.0](https://github.com/ConConner/MAGE-Themes/compare/v1.2.0...v1.3.0) (2025-07-24)


### Bug Fixes

* adjust about page ([acc8fe6](https://github.com/ConConner/MAGE-Themes/commit/acc8fe63863594321e8bd5d0c987273c592d3663))
* data would sometimes not be four byte aligned ([7e954e3](https://github.com/ConConner/MAGE-Themes/commit/7e954e3e4ae00392e7c3eaa30424dc9233e0852b))


### Features

* added settings to area image export ([e771003](https://github.com/ConConner/MAGE-Themes/commit/e77100380c9307909849459d3f080123273abcdc))
* use shift+scroll to scroll horizontally ([6a4a112](https://github.com/ConConner/MAGE-Themes/commit/6a4a112d85c354c4a902e2c3caf02a3b99cb6a94))

# [1.2.0](https://github.com/ConConner/MAGE-Themes/compare/v1.1.0...v1.2.0) (2025-07-20)


### Features

* add legacy documentation for old editors ([1f6ca93](https://github.com/ConConner/MAGE-Themes/commit/1f6ca931795bf025a38ed549b1ef7b5a9f4f055e))
* added documentation for the new tile table editor ([5112d25](https://github.com/ConConner/MAGE-Themes/commit/5112d2514bc5d83f072ed990315eb4432d7865b5))
* adjusted clipdata naming and font spacing (alexman25) ([dcb1ab4](https://github.com/ConConner/MAGE-Themes/commit/dcb1ab4603fb226811c5711307c868dbd990dfb9))
* automatic update check ([9f60048](https://github.com/ConConner/MAGE-Themes/commit/9f60048eb72d771b6998a643a5f959eeb0fa26c1))

# [1.1.0](https://github.com/ConConner/MAGE-Themes/compare/v1.0.1...v1.1.0) (2025-07-17)


### Bug Fixes

* quick theme switcher is now always enabled ([c7ffae3](https://github.com/ConConner/MAGE-Themes/commit/c7ffae3960d924ef7976d45e4efd9fa98bd592db))


### Features

* context menus are themed ([d453df4](https://github.com/ConConner/MAGE-Themes/commit/d453df4f326b246afdc7f8cfeffa501f9783291e))
* new help viewer ([b6ec802](https://github.com/ConConner/MAGE-Themes/commit/b6ec8020b05f288cabffae2ed1cfb356d12bb809))
* tile table editor moved out of experimental features ([29db761](https://github.com/ConConner/MAGE-Themes/commit/29db761f45edc22a25cff82ce167149ba912f215))

## [1.0.1](https://github.com/ConConner/MAGE-Themes/compare/v1.0.0...v1.0.1) (2025-07-16)


### Bug Fixes

* remove new helpviewer for new implementation later on ([65868a8](https://github.com/ConConner/MAGE-Themes/commit/65868a89588c1b2fa715745794a935c1445a9961))

# 1.0.0 (2025-07-16)


### Bug Fixes

* auto setup ([2634db3](https://github.com/ConConner/MAGE-Themes/commit/2634db30cef955d7268cf15c7fa0511942cbf99b))
* crash on auto door setup ([acf651e](https://github.com/ConConner/MAGE-Themes/commit/acf651e612c016d86eba6eeb66fa87fc0dde47b5))
