We could not find a data exchange file at the path System.Configuration.ConfigurationErrorsException: The element <unitTestProvider> may only appear once in this section.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
System.Configuration.ConfigurationErrorsException: The element <unitTestProvider> may only appear once in this section.
   at System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
   at System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
   at TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
   at TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\ebenezer.franklin\appdata\local\microsoft\visualstudio\15.0_a72ddd07\extensions\irwtk2kg.zwt\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\ebenezer.franklin\AppData\Local\Temp\1\tmp769D.tmp --outputdirectory C:\Users\ebenezer.franklin\AppData\Local\Temp\1 --projectsettingsfile C:\Users\ebenezer.franklin\AppData\Local\Temp\1\tmp768C.tmp
Working Directory: C:\Users\ebenezer.franklin\source\repos\UnitTestProject1\packages\SpecFlow.2.4.0\tools