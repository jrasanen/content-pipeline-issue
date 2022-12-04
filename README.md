# content-pipeline-issue

Building the project, or executing thi by hand produces a weird result:

`dotnet "/Users/jussi/.nuget/packages/nopipeline.task/2.2.0/tools/net6.0/any/npl.dll" Jelly/Content/Content.npl`

```
Nopipeline v2.2.0.0
Reading MGCB config /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/Content.mgcb

Reading setting: /outputDir:bin/$(Platform)
Reading setting: /intermediateDir:obj/$(Platform)
Reading setting: /config:
Reading setting: /profile:Reach
Reading setting: /compress:False

Reading content:././Graphics/fire.png
Reading content:././Graphics/jelly.png
Reading content:./Graphics/jelly.png
Reading content:./Graphics/fire.png
Reading content:Graphics/jelly.png
Reading content:Graphics/fire.png
Finished reading MGCB config! Got 6 items.

-------------------------------------

Reading NPL config.

No root found! Using default paths.



Reading content for: Graphics/*.png
    Reading Graphics/fire.png
    Reading Graphics/jelly.png

Finished reading NPL config!

-------------------------------------

Checking integrity of the final config.

Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/././Graphics/fire.png
Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/././Graphics/jelly.png
Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/./Graphics/jelly.png
Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/./Graphics/fire.png
Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/Graphics/jelly.png
Checking /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/Graphics/fire.png

Updating snapshot!


-------------------------------------

Saving new config as /Users/jussi/tmp/ContentPipelineIssue/Jelly/Content/Content.mgcb

DONE. o-o
```
