﻿using System.Collections.Generic;

namespace WinUICommunity_VS_Templates.WizardUI
{
    public static class WizardConfig
    {
        public static readonly string SolutionFolderNameDefault = "Solution Items";
        public static readonly string MinimumTargetPlatformDefault = "17763";

        public static Dictionary<string, PackageRefrence> LibraryDic = new Dictionary<string, PackageRefrence>();
        public static Dictionary<string, string> CSProjectElements = new Dictionary<string, string>();
        public static Dictionary<string, string> UnvirtualizedResources = new Dictionary<string, string>();

        public static string DotNetVersion = "net8.0";
        public static string TargetFrameworkVersion = "22621";
        public static string MinimumTargetPlatform = "17763";
        public static string Platforms = "x86;x64;ARM64";
        public static string RuntimeIdentifiers = "win-x86;win-x64;win-arm64";
        public static string SolutionFolderName = "Solution Items";
        
        public static bool UseGithubWorkflowFile;
        public static bool UseXamlStylerFile;

        public static bool UseEditorConfigFile = true;
        public static bool UseReBuildSolution = true;
        public static bool UseJsonSettings = true;
        public static bool UseSolutionFolder = true;

        public static bool IsUnPackagedMode;
        public static bool IsBlank;
        public static bool HasPages;
        public static bool UseDynamicLocalization;
        public static bool UseHomeLandingPage;
        public static bool UseSettingsPage;
        public static bool UseGeneralSettingPage;
        public static bool UseThemeSettingPage;
        public static bool UseAppUpdatePage;
        public static bool UseAboutPage;
        public static bool UseAlwaysLatestVersion;
        public static bool UseDeveloperModeSetting;
        public static bool UseColorsDic;
        public static bool UseStylesDic;
        public static bool UseConvertersDic;
        public static bool UseFontsDic;
        public static bool UseWindow11ContextMenu;

        public static List<string> CLSID = new()
        {
            "3EB53D8C-1221-451F-80AE-50E5B67E42DF",
            "C122FA58-66F8-4FEE-9256-F687E86CF21A",
            "BF8CCC98-8B35-4E9D-883D-32596535D656",
            "1BAEAACE-66D4-4130-A311-447C495FF65A",
            "C7514747-8575-4834-A261-75D5965C4D82",
            "1BF28981-83A4-4F5B-AC0A-B71016E56F0D",
            "138B4A58-7B5F-4097-8079-426CFD8074B1",
            "CB4FAC6D-0603-4261-8E0C-B3FFEBE0EA49",
            "08769A74-EAC6-4F0E-B7DA-FC88DA7FCC38",
            "A2534D28-D159-4FCC-8EED-A3BDCDB1A767",
            "2FF6D389-E833-401D-AAA9-59269518F115",
            "AD5CC24A-0366-4259-A184-93B7F2CE8862",
            "2923338A-8A83-4619-A608-D722477196E1",
            "01A8D729-0E4C-4C47-B31B-D8E871F7A0FB",
            "900ACC9A-52D3-4AB1-97A1-6E3A09C578F1",
            "9D5D0B47-45F6-4A65-90AF-9787FF77F429",
            "B1F78413-26C2-4CDD-9F59-058BFB9ED09C",
            "657DDCEC-CEC3-4EF1-B08C-3A6121230147",
            "12F1139C-BD78-41FA-8306-947D861B37CA",
            "07563845-49FA-43BE-8C35-67F0B4DB7F7C",
            "B65D1BBD-01ED-43E6-938B-F6C8D216BB2F",
            "BF81D8A8-61B2-4EB3-9BF8-3BC2A0A9F51A",
            "34D1A53A-F4BC-455C-9E01-EB4DA4DBD460",
            "B47213DC-BF60-4AAD-A3AA-94ABCD6648EE",
            "480F4CDD-BFCC-4234-9422-B7DA667B4C7F",
            "6527A01A-FC79-4E17-8FB0-57EE8FF404ED",
            "72845D71-C9A3-43BC-8A2F-0ABB3C59A8FF",
            "446A70B4-370E-4E69-A91B-556CCC2E997E",
            "9FD1B1A1-E7F3-4C17-BD6C-90D544F6E4C0",
            "8CFBBC24-BEA5-4865-8676-178A6A51C682",
            "8CB3B74B-5E0B-41AE-9444-18ECDDAF7912",
            "A5CECD79-A942-4C25-8524-3F460A9428C1",
            "5F5CA407-163A-4C92-A535-2CCAFA41E372",
            "6A90B0AD-7538-4A7C-BF0E-34FAE7DDC232",
            "D9F5577D-3873-4187-913F-9622AC7B89ED",
            "A19F05C4-C66F-4251-A829-285CDC5CB8B0",
            "C732642F-ED59-436D-AFE6-F2CD1F460C93",
            "AA716AA6-635D-4FE6-B2DE-5352DDAA58DE",
            "098A9102-9F1A-4521-87DA-F6D2B6BD3F60",
            "1E7302B6-1804-45FB-81E3-DDD9BCC519FE",
            "6A4A0EB0-7301-42B2-97E4-01A1379C241B",
            "1262EA49-3A2D-41B2-984C-B89428500C7A",
            "B3F4DB05-557F-400B-8123-35484939AEC8",
            "E209EB2B-893E-4619-9621-5671B438272E",
            "601E2B18-0F3A-4498-BA69-29C68768ACF9",
            "47073F00-6B46-4AB8-BB0B-7F22A13AF358",
            "975E401E-A080-4963-8546-B42F2DCA12EC",
            "8E4AEFB9-0D1D-48A1-BF83-7671C1595B76",
            "858FC49D-80DB-41D5-9342-E55632B0100C",
            "1034AE98-5E34-4934-B456-66916FC92F45",
            "4927DF21-D85B-4390-A2C8-15C205CAEF76",
            "84A93716-EAAC-4D91-AEAB-757477FD5357",
            "54E02457-2D19-404E-9041-BF374AB33826",
            "B7CED9E8-C3F6-4800-8225-3D8599473780",
            "EF9E4591-0DD9-4902-9FF0-1430B730F5D4",
            "AEADE573-45D2-4E2E-93E7-B8EC324A3AD1",
            "75042787-2D42-4221-89CE-B023D96633B0",
            "D991728F-3FC5-46D7-A06A-E6D15D3F9E3C",
            "90180805-02B6-42C3-A816-F9427916D193",
            "02E04DB6-FCA5-4B51-89B9-B3977CB2F332",
            "720B6AB8-3314-4359-87CB-7EA4602FC51D",
            "F98CCA1C-5687-4F7A-A355-859D18FEEF12",
            "ED56BF06-F4F7-47E9-B2D0-2767ABC6729F",
            "0565C84F-04C5-4CE0-A027-3977FA7051BA",
            "80748205-A63D-49F0-945C-E311CFC37635",
            "41F962D7-7802-46C5-ACB5-D540E94935C1",
            "ADE3AB5E-7DD5-490F-B6B9-DE9A638D9F72",
            "16EBE486-DD47-4F5B-8ECB-A1090D044A58",
            "076800F9-CBA3-4794-B9A7-AD3C1099FA79",
            "E50D4E91-E3C8-4AA6-88E7-894F49334A15",
            "ECE19D2E-A9ED-4306-8B74-DB394CCDEBA1",
            "2FEA9542-1776-4F6A-A627-0B26775C1574",
            "A8F5663C-5EB5-48C5-BA8E-1718190C5B2D",
            "52242982-498F-4128-82AE-4BDA9E31A645",
            "1863C379-8F39-44E3-834A-1730701593FB",
            "6261B2E6-5392-41E1-9D79-4BC9010FCE55",
            "AE392301-6B13-4268-A9D2-22E8FDCF1246",
            "F0A3BD15-EC46-4A2C-8890-A17840530DB4",
            "09EC61FF-2FE2-44DF-BC77-A41EFFF73217",
            "D1E32093-3895-4E54-9038-9DF4C633ADAB",
            "8D0A3807-1823-4285-A439-8E925C559B80",
            "B00777B2-46F4-4BD4-88F0-43BD46867A72",
            "7A9633CE-6337-4056-BBC0-B74A293D84FE",
            "897E2B9A-DAA3-4618-8011-885F6D4E91E8",
            "BDEB6266-A4A0-405B-9E03-A19A027FDDB9",
            "C0463AEC-0D4E-4603-94D9-EA27AB1F73D2",
            "1A215001-474B-48B9-8DAF-A32EAD14BF39",
            "7F1DD6F7-C433-4EF1-B408-1C754E568F6E",
            "A30014A0-C488-431C-BB36-BEA26506483B",
            "31127309-51FB-4BED-8F79-DA23C185309A",
            "694D3AFA-B6AB-4362-A6D9-940ED5E8894A",
            "D644E532-8072-4BC2-AC8F-62DE32A6B5A7",
            "F8B5A64F-10A6-449B-BBAB-22FB5B4F349A",
            "D289C640-1D22-4612-83C3-6E824C8564E7",
            "CAB2737C-530E-438C-BD8F-3689F83EBC91",
            "640C2863-B2F8-4EC4-B62B-8693D3BB089C",
            "BAA96FF7-99EC-4863-99E2-5EDC15280A73",
            "421977C5-49C7-444D-B850-8BDC8DAE9643",
            "77279346-D64E-4E5D-B1D9-7C34BC43368A",
            "3E85EC54-4C5E-42ED-8572-A0FF76AC3A2D",
            "D61EB1BD-6880-4BD2-B5FD-3C01FF7819D1",
            "11B5D3EC-9729-43C2-BB63-701369A815AC",
            "054731A4-91CB-4DBD-BCD1-AD0F46EE3996",
            "C382FF58-49B6-40C1-92DE-4FC36B9245B4",
            "331D414B-EF95-44A5-B63A-5B412A769367",
            "5E4DC82A-219E-4C9D-A1C1-02E2012C5C20",
            "A720A61A-0356-486F-8311-113531817E36",
            "218C587B-1E3F-479E-8912-69EEF0A6E9BA",
            "18E0AE30-3571-470F-9578-B2FD98FF18EA",
            "96143E19-6EC9-4624-9D84-91C8BB16F27B",
            "F99CBD5E-1D39-4DB1-B545-D6B477363D1E",
            "90593385-9E9E-4957-AA06-2E07CFAA99EF",
            "D54DCE0E-949C-414D-8777-912D5AA39543",
            "8E89AACF-FF10-4A01-9FF4-AD7E62DBD9F5",
            "E556CA69-489D-40B7-8C36-1EEAD65606E3",
            "E3CD0BFC-3673-44E6-8F35-290178372668",
            "792DE678-0059-4EED-9F0F-1A0701AE93B3",
            "95AB385F-AE7B-4CB5-956A-E650BF527178",
            "9D7D426E-ED3B-42FC-A4D1-05EF54487B37",
            "FD6A21C0-E32C-42EC-ABE8-3E09782786AF",
            "E3AA6808-001E-4D12-8683-2AD668E622A0",
            "3336446B-88C4-4BCA-B73A-EEE4DC1F8982",
            "660DE44E-4A58-4EBD-A1DE-7E3DD5F6C130",
            "C4EF89CB-DC3E-499E-A6D2-6F2C9A29FE8B",
            "5DDAF6B1-41FC-4C2F-9BA6-35C4CA668D7C",
            "E9A4B915-3E4F-4D01-B835-E26C9D587A29",
            "F6B03E8C-C103-4D3B-BF17-F5CDF4E84EE0",
            "80C3CC84-D70F-4302-A360-096B00A2B0D9",
            "E59981B3-4142-4851-BFAB-9E75C5BFF54B",
            "283FC4EF-D502-44D0-9831-1DC44EF92E8B",
            "D56EA29A-662B-4076-8CD7-17548B35CD17",
            "47247D6B-0801-4FD2-A85C-51790F889F8C",
            "D5730744-F5CD-413F-A5CC-F86522CA407F",
            "7E803E16-29E1-4762-A370-FCADE3E813AE",
            "EB192576-3C9C-4C20-BFD1-C49BC2612878",
            "FD755D97-34E8-41CB-9298-F1A42A929FD8",
            "C70F48A2-7C62-486F-9034-0815D169F713",
            "58E8AB8D-4EAD-4AF5-91D0-51A6B843AE0D",
            "D6342A32-BD37-418B-89BE-D70A0F90E8C7",
            "34227D1D-2E5C-44E0-A9AD-A66C3F924B4C",
            "E808500F-14EA-497A-ABBD-F30C671E9FE9",
            "0A84AE41-DCCF-4C1A-A44E-80554E37C2CC",
            "9F4DEAE3-33B4-44F4-8F1D-91A233FBCEE2",
            "83512E10-835D-4025-A29B-535B264558A6",
            "4087158E-1CB5-4BA6-8542-29051E8283EF",
            "CD921D08-AABA-4EF0-A43D-916BD3472066",
            "C88CBF18-AAD2-4023-AFF0-998765EBAF45",
            "9B026D9C-D9E7-4D00-AE71-6E79EF0EEF77",
            "725DA344-4469-404B-840A-2D372B531E52",
            "3979C883-72DD-4851-8AEA-A5C9D2E3A0FC",
            "7EF8CCE6-12D9-481E-80FF-6BDE42540511",
            "A4F35E27-D909-4157-AEB5-E93551E795CF",
            "1A9BF6ED-F111-4495-8DFF-43841F7B95ED",
            "3CD0CBBC-4A65-42DD-85AD-6B1CC8CD2FBA",
            "7459E1F4-43CE-4B34-B83D-4AE6E2E46972",
            "6D4CFE2C-4E48-469B-ADCC-A9F17FB31EC8",
            "FE02D6CC-49C4-4658-AE9C-249C3A4CE500",
            "EEEDE63B-5F1F-4019-89C0-E38FA667D848",
            "ADB0A518-9D1C-46E4-93C9-BC11B2A82D38",
            "0223E663-2D5C-4756-92B6-B7E18C2D7229",
            "8AE42839-857A-45BD-B1D8-30FFD5A30C08",
            "3B992E65-0ED7-4E9C-81F4-036378F7DFDD",
            "8F84530E-383D-4DAF-8B10-06F6BF74BD38",
            "32E5010C-AEAD-443C-B68C-703CDC1541F7",
            "F7475B13-3268-42CF-9033-93D72CC6D178",
            "71D71CF1-DA38-4875-8A2B-D58CC40D0741",
            "CE677F60-A574-49E2-BE7F-F9939DEAA5CA",
            "6B06EA8B-0F1A-45C7-A916-0495178C0274",
            "DD558156-56C4-4E49-8620-14AB8AA0AC5C",
            "EEE40E0E-06EE-4DC8-AC80-B3AEA17A23B3",
            "FA07840A-DFEA-4132-865A-51803EE0B071",
            "5103EC7C-69B4-4F8C-81A8-749E7863E449",
            "D76F6DF5-58C7-4327-AC4C-9C7D6C2CCDAA",
            "799415B0-A8FD-4060-A131-2BE5BAB453F3",
            "FAF65A60-2239-409B-B238-4A2F03C01EDF",
            "C5746DBE-90E3-4844-9D63-3F09723CA086",
            "02D14319-0ED9-438A-BFA0-ED74891F95C8",
            "6E615660-8D78-4051-94E3-7E3030564E21",
            "41AAD794-AFB3-4BC3-BC6D-7B31B2D2E429",
            "3AB974A5-637E-4C8F-81A3-98DA579F1450",
            "4FF304F3-5BA3-4446-9AFE-DB078D9821B1",
            "7A9C5BAC-2713-4B44-94F0-515779C7A164",
            "15CDE265-47F2-4D5B-99C8-141DA3E28114",
            "695B262C-0D2C-4A8C-B6E4-4135E5EDBE33",
            "7E0D4EAB-DB6A-4B98-9F36-2D61CA666C3A",
            "C7A5773D-7D0C-471D-81B3-E4D98727F019",
            "B258CD50-EAA5-4DB2-8E48-D6BA57C65852",
            "B41FF4D3-2059-4C1A-A3AD-7B8CC2586012",
            "F7DD75A6-30F3-4369-9759-BC49A85ADE4A",
            "1C17B22E-28FD-475E-875F-F50209869FE1",
            "46EA85E9-0923-4411-A9FB-0053146625A1",
            "57BF93D1-293F-4A02-B46A-DC0903530D88",
            "7CC29D9D-AC90-4607-B6F0-6F5BDDD8D177",
            "3BE21D92-3517-4C04-B932-3FD6E1647A03",
            "4E206E36-886A-4CF3-B835-08222A1724C5",
            "88A272A3-F5E0-4C27-AC56-446BED0DFEA5",
            "C392BDB0-7E10-4BD7-A51C-16CACE03B374",
            "88B31C39-FA65-46B1-B472-E9B748E0E96D",
            "5FFE65D1-ED9D-4EA9-90CB-D50D532D2C53",
            "1E84DE4B-9781-4AB4-80D3-21EB5B13C989",
            "03E0923E-2B8A-44C9-AD61-7B7626FEA1BB",
            "857F3B9D-2484-4886-B78A-9F7190D4B3A5",
            "7FAE73E2-AEFF-4761-A779-82A9D514AA30",
            "97D196BA-B767-4C2E-956B-76355AEDDDD7",
            "2549A487-CF3C-4F09-8030-B12397A57B69",
            "6E6E3C6A-1879-4C49-AE2F-EF5F5B21B693",
            "B56C0CBF-F297-46BA-B0CE-3846C4AFC164",
            "E3DE1600-FF2F-4711-9B41-1C9AF44AD63B",
            "1D51BDA1-1387-4E8B-8AF5-D5744C2B241A",
            "4191B75F-C80D-4DBB-9483-15A6AFD913BC",
            "7FBAD2B9-D45C-4398-8F7B-D4EA3195B5EB",
            "C62FC579-ED9D-46B6-9456-2F48F8B406B0",
            "7DFED6F3-8350-4A39-994A-055CFB146295",
            "C3245C8E-6D53-4C80-83B9-FAA3D9B6E53C",
            "3E398876-C119-4E56-BDFB-BDA9D90DAB53",
            "5D901661-2E55-4769-85A4-EBC279AB883F",
            "A7BF1CD9-9ACD-4B8E-B65D-FB4EF5172C14",
            "C7DE5183-FC84-4AA9-841C-1B9499FBE736",
            "1358A21B-B312-49F2-81B1-60292C830606",
            "10BC167B-E18C-4A4B-8EF7-10C2B6AC8915",
            "45BDC1D5-F3D1-4438-8AE3-7832C638C60F",
            "4960BA23-165F-46EB-89C4-9B928E0C8FD7",
            "D059025A-CA1E-4941-A039-8D6EE5CA0EC6",
            "3AB1F511-F5A2-46AB-ACA7-83FA9CA66B02",
            "DD923277-5852-44D8-A0D8-F31D71A7A351",
            "625D5239-53D4-4903-AC63-BD8ED4BD3558",
            "F539ABAE-EC4C-4316-A642-6B77FB771C29",
            "7B899BE8-EEC8-43BB-80CF-23BF42D03507",
            "37E49BF5-85A6-4778-ABE3-316293EC0EB7",
            "75D341B0-DCAB-485F-A814-7BCF978BD070",
            "70C630C8-6B2B-4B4E-8AB6-348DE17AE60B",
            "B385978B-F7AC-4DAF-A147-6ADD6D9AF24A",
            "B5AC34F4-0B97-49EE-B9C2-B3763734C626",
            "F79F47B3-F172-47F4-ABF0-63C48D0B17B0",
            "05778F7C-8930-40C9-B382-983BEB992E5C",
            "3B39A72C-9914-417E-B691-C836F68EE1E9",
            "930B9E1A-9A58-4794-8100-17D0F0BFC792",
            "8F69D71D-935B-467F-9D0F-0C5FC7E3308C",
            "58295B8C-4D6D-49BC-8449-D8E1EAB8E612",
            "0F1131F2-096D-4B9A-B6F7-A6706E22F6BC",
            "E69DD4EC-4359-4291-AEAE-5D084BFF07A5",
            "4C76B773-B95F-4EE8-A467-C03A242BEB73",
            "AA03B48F-F812-4FF8-AB15-8B0AF821B5B5",
            "17D6A0F2-558B-4A08-A8AB-5D888FD4890B",
            "6F188B2D-FB21-4243-82EC-1BB03E1DF7C3",
            "6966F246-B0A2-4933-92AE-72B53D33E3EF",
            "931AB3EA-E24A-426E-B1D1-DCF0469DF2A8",
            "330DEDAB-4156-49E0-91AA-9286C8B9F4B3",
            "BD8382C8-BC93-478E-8019-1A31A19356EF",
            "4CCA5CC8-D36E-4205-B9E3-92F4D21FDE74",
            "58C2CBA5-542C-41D9-9F70-BD23D28C2E09",
            "A7FC2D3A-8329-4B95-A984-C275B96CB26D",
            "9D867AC0-F308-4DF6-8D1F-969FFC73CBA6",
            "6825E3F2-52D6-4F5D-A072-1F65053530BA",
            "C3F2C302-7C3A-4B04-AE2A-59D247125DC4",
            "12AB21DD-9708-4C76-9085-2A82C3A57535",
            "A5BE1860-4410-4073-8613-9D2B9852843D",
            "B9EC40EC-1D68-4811-B013-25D5E1E4758D",
            "4CF3D9BE-9741-4863-85AB-A6F7AA2F66D2",
            "D84F8F37-D8F7-47CA-B084-FE432CED9B8D",
            "94030869-6BA6-486D-AA02-1EFE97076BA5",
            "4B973DB7-B904-4639-B44E-65A4A04F89FC",
            "4287E687-A377-4063-BA96-C17CBDC650CE",
            "03736849-165C-4160-9D42-433D0B2CEFF1",
            "22265A2D-1594-4325-A9F8-A947CE9AC0AA",
            "352C64D3-F233-429D-B783-EA77C8DB82E5",
            "7E964C51-F42B-4EFE-9017-72DAC536D6F7",
            "F610FA37-8487-45B9-913D-9BE5F8DFB2CF",
            "44C1EF4C-6948-4ABB-944F-90790DEBC80F",
            "1309CE7E-E31B-438A-BBFB-F25A29B4F7A8",
            "60167C66-67DC-4A8E-A8A4-58A884B4151B",
            "9873B3BA-0135-4628-9BE4-3F480CA1A003",
            "6447C34D-518B-4607-A159-731D94D7AD50",
            "E44E425F-BF6F-4781-A361-2D15267C920F",
            "E524A39A-47A8-4EB5-AB54-D8C37C9F7079",
            "E8FB73BF-2C26-4357-8845-131676102CFF",
            "3FC40ED1-F316-48DC-9941-DE10B672F06A",
            "51B7C778-6632-455C-9131-EA5A0B5EBA06",
            "5BBAFB01-6A20-41CF-8595-D8F5DC73A23F",
            "C99C8F22-92A7-4BB6-BE79-C749A7411246",
            "D5655AD9-F7B8-430F-9B02-7FBFAD0A914F",
            "A808D773-E814-4654-937B-5494D2DEC946",
            "EA5D8D86-AB09-4F66-9F72-545819F54B39",
            "34F5742F-25B6-44AF-BF81-75CAD78C877A",
            "2C943B7A-881B-479B-AD0B-7A5A704132AB",
            "15895EA9-7121-4E94-94AB-6FD2513267EF",
            "AEAC988D-4F56-4D8D-ABBE-57141F3C1BDE",
            "73C54FDD-9E27-4C83-B749-19A9429ACEA3",
            "480FD77A-9E25-4E47-B0F9-B8B2D0236C54",
            "14F19436-7A10-478E-AF66-DDDD57AB9092",
            "F023984E-4803-429B-877A-54E72EAD637A",
            "856B62C3-4606-4A58-8DD3-88EFC7E4671C",
            "4EF8B412-B984-41E2-8B67-58BBD1DA486D",
            "97ADE4EE-E8AA-4CE1-ABBB-DFEF18CAC0A3",
            "7EA688BC-B319-48B6-8D85-FAF3EEA64FBE",
            "48F66C80-C65F-4FD9-A295-F306D7D15110",
            "141C364F-E16E-4790-8629-D082D0770066",
            "F0E70638-D472-449B-8B59-BBB8FD224074",
            "D3B0DE2B-4DA4-4CDF-BC06-F6D710D417EF",
            "E3FE215C-44F6-418B-9E8B-62D8866F0C93",
            "03ADF26B-0103-426E-B62C-E0151265CB22",
            "716423B2-21DD-443C-9AE9-447B41C447F1",
            "61C8FAE5-7A57-4B96-A6E9-3960FCDF986F",
            "0774FD63-3D6A-4B2B-BFC5-DD1A7D667FC8",
            "F02ADBF0-05E4-4559-96D7-E41D4C4B9CB7",
            "DAB60ACD-D897-4D4A-BE57-D3A1471E75EA",
            "EFBF4CCE-F83A-4486-AB60-6E987E87AE8E",
            "2921035E-24BD-47F3-AEB4-2A1BBEDE5EFE",
            "4D605CBD-478D-48B4-9BE0-8241ACA72BC0",
            "2D3F60C6-FF0E-421F-AD5F-64F8026CB39E",
            "F37072F5-C3EE-4AF2-8E50-35AC924EFE02",
            "B246F793-3F6B-4D23-B68A-71500C2E8BFA",
            "C265EBE8-FB94-4211-A42C-FC87F0AE354A",
            "FBA0FCBE-E8E2-4A2E-B2A2-8A7B6C6541C2",
            "8489C2F2-DEF3-453C-96CE-4C1795651541",
            "B99ADAF9-A732-4883-BF9F-F95A149E1C4F",
            "ADB05A24-1E55-4544-B59C-BE1CFA284212",
            "3A1410BA-CE54-469B-BD2C-3216DE343BFD",
            "04BF6C59-9A88-489A-AA25-21BCE060DC7F",
            "872A55FF-A7D3-412F-BA95-579E18AD0BF4",
            "D74D7A63-DC50-4AD5-BF37-33A00E9F990E",
            "1160F111-E564-4D00-9637-A01BFDB28BCF",
            "4CD4B15D-A4FF-4A55-A4CE-4099BC809C36",
            "BCF01CD7-0DA9-492B-A082-F42A81411BBD",
            "33AD666F-6269-4779-9FCB-E59E50688F87",
            "C955FD3C-10C5-4446-A2B5-90424453483D",
            "E870BC6B-7F5B-46BA-BFDE-CE5B5C39465E",
            "14E8D1CF-9EF9-4599-B429-98926D3A1B5D",
            "F1E18529-E22A-4231-A784-2CEC029FA93C",
            "2FA6FF22-4E83-42E5-A618-6A44D546D201",
            "1FADD0C8-4E33-42B9-B2DA-C36FD10E280F",
            "57F7019C-B9D7-47D9-96F2-2F22C1D82E48",
            "09A22874-CAA7-4A09-8231-EA80E29089AE",
            "F2F546C0-CE5A-4040-A28D-BA6CA3AE0ED2",
            "997EF4CD-EACA-4CED-989A-73FDD84673C6",
            "7AD4A27D-809A-484F-BD12-70E2A2B1245A",
            "01D5F5EA-B13C-402D-999C-51691365EF10",
            "204B9E3D-3420-407D-9D8A-6DA9AFA3E672",
            "3B3F0008-1D49-455B-9C8B-BC45131BC572",
            "0F753034-9D36-4F78-9ED2-F7A219EAAC84",
            "F6CE1C9F-A9F8-4C4E-82DC-FCCCBA68F09B",
            "69E4B54F-2B17-4166-8559-D46AF41FFA1A",
            "9C842EC4-94DF-479B-8BBF-5F39AF22D0D3",
            "8CE3E889-78E2-4F29-8B7A-12DE4F041612",
            "2DF35962-224C-488E-A36F-2271E15A1532",
            "550E4EC8-0D50-4F5F-A75B-CA8BC08A878F",
            "17136ACA-00F7-452F-9E94-3B52419187E5",
            "659FADC9-010A-46A5-AD8B-1346CA5873C2",
            "AB0BA3FC-5E47-4B3B-9F58-5DFEE8266E4C",
            "A143913A-E3FE-4C40-ADE1-70430DB530F0",
            "5C468AE1-D49D-4CA7-B39C-D4D2A9FCE70E",
            "26AB1F8B-189C-4382-934E-90BEED97C104",
            "B56169B6-B251-4391-9086-80847E27C6B8",
            "BCEA6FB1-ACEE-47B5-B410-4F3918A4AB49",
            "8052D7E1-47E8-4E0E-B7D6-56DAA0B16AA6",
            "122A02AA-9EC0-49F8-A1D6-8AACFF7FAF3D",
            "7A74DE17-112C-41FD-952D-2C49F044C5BD",
            "39883A40-83BA-402D-85B5-1E52641AB953",
            "CD5A0B59-D408-4B28-8ACC-8D59A4ED58C9",
            "65B83D30-B29B-4727-99AE-42DB3ECDBE9C",
            "2CC67269-A79B-44AB-B6F6-456ED9C556FA",
            "56FE873C-674C-4377-8ABC-25C4561DCD21",
            "1078C6F9-D760-4BF1-8E28-975CFF78C951",
            "8BC5C838-498B-4648-AF01-B2BB13D44B02",
            "13A2BECC-FF11-4969-828A-DA9FA89F6534",
            "20921B64-5017-4B0F-803F-BD60F2681022",
            "652982BE-25BA-4400-9587-01D7131DEFE7",
            "AEB66701-E682-4EEF-BA14-81E1189DF9FB",
            "B02F571B-1061-4FF6-863C-751C3304D760",
            "D2D0009A-A242-4090-B359-52A823688217",
            "E4572981-6B7D-418D-A972-9290D9430415",
            "DD5A1FDE-974E-408B-AB2B-8DAADF40EA4E",
            "D71677AC-A673-40AF-8A7A-DCDB7CB31B5A",
            "18E4CA89-A842-4826-A5F1-9F2FC7D77F94",
            "DECA3E4A-31DA-4D3D-A78B-BF0C32C8AD6A",
            "EFCC3143-1C39-463B-B6EA-4D2B5986F61E",
            "8E9F36DE-1F58-4F1C-9D37-3CE0D91E450F",
            "7B356E59-8620-4B02-9A51-8BB4CC37C5B6",
            "E11EB486-8244-423C-A941-48EBF827B117",
            "0D3A15D7-44B1-4DDB-8D83-A268099C5AEA",
            "CC435C65-974A-40B7-88C6-126B353CF1B5",
            "0CB30BA6-E8BB-4DAC-A27F-A879D2D8F535",
            "60C10871-D3AB-4975-9DA2-A739F3E9DB63",
            "C6564EA1-5A40-4369-AE99-12B15F4CD432",
            "C89C742A-BB82-493D-A62D-0933B65BCF4F",
            "F4E89B60-A38E-40CD-B95C-9020B0491BAB",
            "B83CD26A-C34B-4415-8580-51B4CB02422E",
            "15447B04-A505-4C1E-806C-326317A8F9D7",
            "2F1D2689-ABF9-434B-B835-9D30472C5033",
            "5CFBAB17-0383-40A0-B6D2-4D912552DC05",
            "BAFD4D5C-6014-4018-9122-FC8223D21117",
            "C5E61241-60E5-4937-A338-2F09385794D4",
            "DC1308A5-FF23-4ECB-8B9D-361D153BF795",
            "FCB4F141-3EA2-4002-B11E-D0F278E560BB",
            "3A9226D1-E36E-4D1E-919A-FCB88852CDA2",
            "BC8CA397-AB45-4601-B426-88778BD63861",
            "FD984C2F-C583-46D7-9C30-3D664FE86E8C",
            "C9B41D05-D369-45A6-843F-CBD74DED9315",
            "E0A50B3E-7025-4C1E-A7F5-7D1A2C976863",
            "C4CDAA15-1650-4173-BAB5-5FFA2D1FCF28",
            "2DDC6C82-7A93-4EAB-BAF4-DD6446019913",
            "A8F3DC28-A441-4646-803A-09088B69DBC2",
            "C08B0361-54B1-4277-9B3B-DCF9ECB722F6",
            "084D33D3-1063-411D-841B-DDA5D435157E",
            "64875D8B-16A3-4725-8131-3B4A93EEE9FB",
            "74F2C4B6-30B3-4848-B601-D38730BD551A",
            "EEC32354-86A6-4220-847D-0EFA29E82F47",
            "7DE85987-39FB-49F0-A754-A86E45FC5FD4",
            "89BDD247-C48A-4E38-AF5E-42CE35AB05CE",
            "EDBD215C-5408-48BA-8095-1564AC8D200A",
            "F24DC6BF-71AB-4FEF-8270-E95D84C9FA5E",
            "DFC950FC-06AC-4046-8EBC-FEBA42605ABD",
            "C364A234-3981-4C73-97BD-621545C36705",
            "BB2FD88D-759C-4A2D-B4A4-AE4F81AB21E1",
            "C1AACF3D-9BD1-4573-AABF-D73FF67A825C",
            "7E7D5D06-CCDB-4393-9426-86AB03801C3D",
            "F0E39793-82BF-411E-88DA-C0DD6DB547AC",
            "7EEDEB5D-BBFB-4E7A-ABBB-53291F4B14EB",
            "F9C0F6F4-122D-4E58-9D19-9DEE760FF040",
            "4D7C9A3A-8F65-470D-9C05-2DC074D4BEC2",
            "A4C7FC84-5280-4497-8502-E1807940EB32",
            "454176A6-8C15-47CC-93B8-FED76AA7AE63",
            "96795480-69F9-4281-A66F-1438CDC9B451",
            "382FEF19-2F3B-4E3B-89B9-19F4995863AD",
            "B12728CB-77E5-4B48-A5F6-307B63EDEEE9",
            "4F69F2C1-6D8B-42E6-A587-1C7068ACB32A",
            "4437CC0E-F7E0-412C-A1A4-E806416E21D2",
            "847BBBCB-9986-4525-8F2A-D712BBEEDE2A",
            "5AB92059-E1FA-461D-9905-4FBC42C4391E",
            "CFA25B90-8629-44FD-AD91-D39D997CE892",
            "DCA1891E-7ABB-445A-B4B6-4602EDD201EB",
            "BA1E4BBF-3119-4E6B-97EF-F5298FFAEB3B",
            "F60E062F-8D4A-4B45-A361-855C76EE46AA",
            "00F0563D-D7FE-48EF-B49F-C8F64C82FF78",
            "3886A666-D9A1-41E4-9FC5-7C432BB09605",
            "62415847-2EDC-404E-B252-7D97896CD210",
            "19DAD91C-A759-483D-8D19-98AAA9FDC1AC",
            "055F500E-FB08-4CF8-8DEE-A4C61862A6D8",
            "0100B04A-7D0D-4A51-A444-319738BC1BD2",
            "9B558C1E-4CBF-465B-9B85-7380BAE9BD1C",
            "7B664A52-CC3D-4F3C-8ACF-0D5BC6536B12",
            "8754A15B-5BF2-43F6-8951-0E6596862118",
            "6776B1BE-C53E-484B-9B7F-93A091B9831B",
            "72E21015-A7F4-4263-BAF7-D87632097383",
            "82118E48-6198-457D-9A34-D77D90AB2301",
            "C628ADA1-9A1C-4E9A-8F1F-A1B71D718773",
            "228CCEB3-3E62-4859-904A-9E726B8474F8",
            "9A766D04-CB78-4877-853F-45E73487DFC1",
            "3D6CB68E-408A-4906-8AE5-EC6D624639C4",
            "6ED31806-F5EE-4456-AE3D-55FFB807B23B",
            "C5928BA3-CA5D-4E7D-ABE2-2FBDE145232D",
            "936AD9D7-A016-4DEB-BA95-8DFAB573B1A8",
            "D10DF260-39F8-4296-938A-F8044E049789",
            "20796C0F-6C51-4284-AA83-2CB4B982D468",
            "A933B22B-CFFF-403C-9FC9-DDDFC04FCD93",
            "DE9D63D1-1030-4B79-8503-9B65FE5000F1",
            "88C507FC-04CB-4715-BDC5-8AF077278A2B",
            "F7BDC045-102E-4F7C-B056-8189F9E35314",
            "F3BFA013-C5E1-4FDB-81D6-2E7AB5DE53CE",
            "0DF35CEB-93C9-4FBB-B965-2B91C7BD0FAA",
            "4D923A61-F79E-4776-AF0A-22419CD02745",
            "6040FC4A-9090-403B-BFE0-DD301B4C3C46",
            "8E7CFB75-08EE-4076-8CE0-146DB6947B22",
            "2A9C2C3E-8321-48B2-B9B4-EAFDB00FC033",
            "E1A37DD4-7BB1-41E8-911E-B7A96B981F89",
            "3BF647A4-F126-4373-8564-6ABC5F6EC39A",
            "254DDDF0-0BA9-4E4F-A1B4-4E404840D5C1",
            "65566D13-5723-498D-95B8-8B4ADAB93A5C",
            "DBCEAD22-D7B5-41D9-9166-E41751D28312",
            "01339F7F-30A9-40D1-AA1C-B03AE707929C",
            "31C4F4B4-17E7-4023-B328-79C5774D5DF4",
            "462FD259-6705-4917-A638-B655902E9D31",
            "FCB9B9DB-2952-4432-8678-2CC9AF07CE7E",
            "5B3F2B63-DE0E-4726-9B51-F8CFA0368674",
            "07D1AF00-994A-4CBA-94F1-B0F4710D7CD1",
            "7F89813B-6689-4DBB-BDB4-08708FE49825",
            "1F7FE366-4C36-4F69-A322-7CB81611E02C",
            "114DE3E5-F494-4CA5-B171-08EE88862C33",
            "17810024-A70E-460A-BD51-6F968BBB1716",
            "996AFBA7-E45A-408D-A9F5-FDC23095CE01",
            "58C3223A-EEB2-4354-AF0A-D0376776B2B0",
            "14161807-5299-48A4-AED3-AFCADB615171",
            "C9F723CE-2456-4385-93D5-7A383A7086AF",
            "ED1957FC-F40F-45CD-9F82-89FE876911C7",
            "231C03B7-D24C-40C1-8C2A-321C23536753",
            "8C72F0E0-3723-4105-AB8D-3508D04271B9",
            "1481957A-64D3-477F-A456-2E8AA62085BC",
            "0CF099E9-8D8A-40CC-B8C8-BFA7E02B7361",
            "6D1E4610-74FF-42CC-95EB-7F26AF4F8E2E",
            "C05F50CD-405A-42A9-9E0B-404742EC1FAD",
            "8331E217-E236-4B8D-B776-312D087DDD6A",
            "4F46797F-30FE-44F3-B00C-0C5C940B8BD7",
            "AFC913BB-2270-4BFA-9040-3C28F75ACDB4",
            "E0DE5C2B-CB56-41A8-8E11-87FD2376D1FE",
            "BA5924BD-2276-4742-BF46-CB0BF76BA158",
            "268E751D-0217-49FE-BB3B-E5D409780B33",
            "D03DC1CC-0CB3-4801-BF42-BA6AB2A5B335",
            "BBBA13FB-7034-42CF-A137-A87BD1F0D409",
            "C4ED2728-4206-497F-B0D2-FDB630452218",
            "3EEACA57-80D4-4829-9E19-BDF5874EF101",
            "CAA7B0B4-4245-4C18-80AA-BB23B23308FC",
            "7D72951C-E734-4B83-8185-30A94D7A2E36"
        };
    }
}
