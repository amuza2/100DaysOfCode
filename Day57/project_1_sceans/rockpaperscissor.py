import sys
import pygame
import random


GRAY = (128, 128, 128)
WINDOW_WIDTH = 600
WINDOW_HEIGHT = 500
FRAME_PER_SECOND = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

ROCK = "Rock"
PAPER = "Paper"
SCISSORS = "Scissors"
win_choices = {
    "Rock": "Scissors",
    "Paper": "Rock",
    "Scissors": "Paper",
}


STATE_SPLASH = "splash"
STATE_PLAYER_CHOICE = "player_choice"
STATE_SHOW_RESULTS = "show_results"

# Initialize the world


# Load assets: image(s), sound(s) ...

# Initialize variables
player_score = 0
computer_score = 0
state = STATE_SPLASH

# Loop forever
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()

        if state == STATE_SPLASH:
            if start_button.handleEvent(event):
                state = STATE_PLAYER_CHOICE
        elif state == STATE_PLAYER_CHOICE:
            player_choice = ''
            if rock_button.handleEvent(event):
                player_choice = ROCK
            elif paper_button.handleEvent(event):
                player_choice = PAPER
            elif scissor_button.handleEvent(event):
                player_choice = SCISSORS
                if player_choice:
                    rps = (ROCK, PAPER, SCISSORS)
                    computer_choice = random.choice(rps)
                    if player_choice == computer_choice:
                        result_field.setValue("It's a tie!")
                        tie_sound.play()
                    else:
                        result = win_choices[player_choice]
                        if result == computer_choice:
                            result_field.setValue("You won!")
                            win_sound.play()
                        else:
                            result_field.setValue("You lost try again")
                            lose_sound.play()
                    player_score_counter.setValue(
                        "Your Score:", player_score)
                    computer_score_counter.setValue(
                        "Computer Score:", computer_score)
                    state = STATE_SHOW_RESULTS
        elif state == STATE_SHOW_RESULTS:
            if restart_button.handleEvent(event):
                state = STATE_PLAYER_CHOICE
        else:
            raise ValueError("Unknown value for state:", state)
    if state == STATE_PLAYER_CHOICE:
        message_Filed.setValue("	Rock 		Paper 		Scissor")
    elif state == STATE_SHOW_RESULTS:
        message_Filed.setValue("You 							Computer")
    window.fill(GRAY)
    message_Filed.draw()

    if state == STATE_SPLASH:
        rock_image.draw()
        paper_image.draw()
        scissors_image.draw()
        start_button.draw()

    elif state == STATE_PLAYER_CHOICE:
        rock_button.draw()
        paper_button.draw()
        scissor_button.draw()
        choose_text.draw()

    elif state == STATE_SHOW_RESULTS:
        result_field.draw()
        player_score_counter.draw()
        computer_score_counter.draw()
        restart_button.draw()
    pygame.display.update()
    clock.tick(FRAME_PER_SECOND)
