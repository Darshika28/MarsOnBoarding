Feature: SellerProfile
	




@mytag
Scenario: (Profile)As a Seller I want to add my Profile
Given I am as user at my profile page
When User add personal details in profile page
Then User is able to see Profile details

Scenario:(Language) As a Seller I want to add my Language in my profile
Given I click on Language tab
When I click on Add new button
And I type language I know
And I choose my language level
And I click on Add button
Then As a Seller I can see languages detail in my profile


# Scenario: As a Seller I want to add my Personal skill in my profile
# Given I click on Skill tab
# When I click on Add new button
# And I type a skill I have
# And I choose my skill level 
# And I click on Add button
# Then As a Seller I can see skills detail in my profile

Scenario: (Education)As a Seller I want to add my Education details in my profile
Given I click on education tab
When I click on Add new button on Epage
And I type my university name I studied
And I choose the country of my university 
And I choose the title of degree
And I type the name of my degree
And I choose the year of my completion of degree.
And I click on Add button on Epage
Then As a Seller I can see Education detail in my profile


# Scenario: As a Seller I want to add my Certificate details in my profile
# Given I click on certificate tab
# When I click on Add new button
# And I type a name of certificate I got
# And I type name of institute who gave me certificate
# And I choose the year when I got certificate
# And I click on Add button
# Then As a Seller I can see skills detail in my profile


# Scenario: As a Seller I want to add description details in my profile
# Given I click on edit button
# When I type description under 600 characters
# And I click on save button
# Then I can See the description on my profile

