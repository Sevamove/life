namespace UI.Console.Enums;

public enum ComponentId
{
	// REST API CRUD buttons.
	PostGameButton,
	GetGameButton,
	GetGamesButton,
	PlayGameButton,
	PutGameButton,
	// Anchors with href values.
	GoToGameNewPageAnchor,
	GoToGamesPageAnchor,
	GoToHomePageAnchor,
	GoToPlaygroundPageAnchor,
	// Navbars.
	HomeNavBar,
	GameNewNavBar,
	GamesNavBar,
	PlaygroundNavBar,
	// Inputs.
	InputWithLabel,
	GameNameInput,
	CellPositionInput,
	GridAreaInput,
	// Pages are a components here.
	HomePage,
	GameNewPage,
	GamesPage,
	PlaygroundPage,
	// Other buttons.
	PauseGameButton,
	QuitGameButton,
	// Forms.
	NewGameForm,
	// Invalid components.
	InvalidComponentId,
	// Lists.
	GamesStackedList,
	// Sections.
	GridSection
}