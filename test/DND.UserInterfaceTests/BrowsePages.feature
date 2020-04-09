Feature: BrowsePages
	I want to view the different pages

Background: 
	Given I am on the home screen

Scenario: Browse Pages
	When I select the BLOG navigation link
	Then I should see the Latest Posts screen
	When I select the GALLERY navigation link
	Then I should see the Gallery screen
	When I select the VIDEOS navigation link
	Then I should see the Videos screen
	When I select the BUCKET LIST navigation link
	Then I should see the Bucket List screen
	When I select the TRAVEL MAP navigation link
	Then I should see the Travel Map screen
	When I select the ABOUT navigation link
	Then I should see the About screen
	When I select the WORK WITH ME navigation link
	Then I should see the Work With Me screen
	When I select the CONTACT navigation link
	Then I should see the Contact Me screen