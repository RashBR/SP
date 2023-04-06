@UI
Feature: MordernWork

A short summary of the feature
Background: 
	When the user is on home page

Scenario: check the Employee Experience  
	When the user selects the Solutions & Services menu
	 And the user selects Modern Work
	 And the user selects Employee Experience
	Then the user is able to see the header as 'Employee Experience'
	 And the user is able to see the paragraph starts with text 'Engaging, Mobile Intranet and Digital Workspace collaboration solution.'
