
//window.soundManager = {
//    soundEnabled: true,

//    sounds: {
//        click: document.getElementById('click-sound'),
//        success: document.getElementById('success-sound'),
//        error: document.getElementById('error-sound'),
//        generate: document.getElementById('generate-sound'),
//        validate: document.getElementById('validate-sound')
//    },

//    toggleSound: function () {
//        this.soundEnabled = !this.soundEnabled;
//        const button = document.getElementById("sound-toggle");
//        if (button) {
//            button.innerHTML = this.soundEnabled
//                ? '<i class="fas fa-volume-up"></i>'
//                : '<i class="fas fa-volume-mute"></i>';

//            button.classList.toggle('bg-gray-200');
//            button.classList.toggle('bg-blue-100');
//            button.classList.toggle('text-blue-600');
//        }

//        this.play('click');
//    },

//    play: function (key) {
//        if (!this.soundEnabled || !this.sounds[key]) return;
//        const sound = this.sounds[key];
//        sound.currentTime = 0;
//        sound.play().catch(e => console.warn("Failed to play sound:", e));
//    }
//};
// ASGSTATSound Management

const clickSound = document.getElementById('click-sound');
const successSound = document.getElementById('success-sound');
const errorSound = document.getElementById('error-sound');
const generateSound = document.getElementById('generate-sound');
const validateSound = document.getElementById('validate-sound');
const soundToggle = document.getElementById('sound-toggle');

let soundEnabled = true;

soundToggle.addEventListener('click', () => {
    soundEnabled = !soundEnabled;

    soundToggle.innerHTML = soundEnabled
        ? '<i class="fas fa-volume-up"></i>'
        : '<i class="fas fa-volume-mute"></i>';

    soundToggle.classList.toggle('bg-gray-200');
    soundToggle.classList.toggle('bg-blue-100');
    soundToggle.classList.toggle('text-blue-600');

    playSound(clickSound);
});

function playSound(sound) {
    if (soundEnabled && sound) {
        sound.currentTime = 0;
        sound.play().catch(e => console.log("Audio play failed:", e));
    }
}

// State Management
const stateCards = document.getElementById('state-cards');
const stateField = document.getElementById('state-field');
const addStateBtn = document.getElementById('add-state-btn');
const clearStatesBtn = document.getElementById('clear-states');
const emptyStateMessage = document.getElementById('empty-state-message');
const stateCount = document.getElementById('state-count');

addStateBtn.addEventListener('click', () => {
    const field = stateField.value;
    if (!field) return;

    if (stateCards.querySelector(`[data-field="${field}"]`)) {
        alert(`Field "${field}" already added`);
        return;
    }

    if (emptyStateMessage.style.display !== 'none') {
        emptyStateMessage.style.display = 'none';
    }

    const card = document.createElement('div');
    card.className = 'state-card bg-gray-50 border border-gray-300 rounded-md p-3 flex justify-between items-center';
    card.dataset.field = field;
    card.innerHTML = `
        <span class="capitalize font-medium">${field.replace(/-/g, ' ')}</span>
        <button class="remove-state text-red-600 hover:text-red-800">
            <i class="fas fa-times"></i>
        </button>
    `;

    stateCards.appendChild(card);
    updateStateCount();
    playSound(clickSound);

    card.querySelector('.remove-state').addEventListener('click', () => {
        card.remove();
        updateStateCount();
        playSound(clickSound);
        if (stateCards.querySelectorAll('.state-card').length === 0) {
            emptyStateMessage.style.display = 'block';
        }
    });
});

clearStatesBtn.addEventListener('click', () => {
    const cards = stateCards.querySelectorAll('.state-card');
    if (cards.length === 0) return;

    cards.forEach(card => card.remove());
    updateStateCount();
    emptyStateMessage.style.display = 'block';
    playSound(clickSound);
});

function updateStateCount() {
    const count = stateCards.querySelectorAll('.state-card').length;
    stateCount.textContent = `${count} field${count !== 1 ? 's' : ''} added`;
}

// Technique Management (placeholders for your existing logic)
const techniqueSelect = document.getElementById('technique-select');
const selectedTechniques = document.getElementById('selected-techniques');
const emptyTechMessage = document.getElementById('empty-tech-message');
const configureConditionsBtn = document.getElementById('configure-conditions');
const selectedCount = document.getElementById('selected-count');

// Scenario Generation (placeholders)
const generateScenariosBtn = document.getElementById('generate-scenarios');
const validateScenariosBtn = document.getElementById('validate-scenarios');
const scenarioResults = document.getElementById('scenario-results');
const scenarioSequence = document.getElementById('scenario-sequence');
const validationResults = document.getElementById('validation-results');
const scenarioCount = document.getElementById('scenario-count');
const validCount = document.getElementById('valid-count');

// Operation Log
const operationLog = document.getElementById('operation-log');
const clearLogsBtn = document.getElementById('clear-logs');

// Visualization
const attackGraph = document.getElementById('attack-graph');
const graphSvg = document.getElementById('graph-svg');
const tabButtons = document.querySelectorAll('.tab-btn');
const tabContents = document.querySelectorAll('.tab-content');

// Modal Elements
const conditionsModal = document.getElementById('conditions-modal');
const closeModalBtn = document.getElementById('close-modal');
const cancelConditionsBtn = document.getElementById('cancel-conditions');
const saveConditionsBtn = document.getElementById('save-conditions');
const modalTechName = document.getElementById('modal-tech-name');
const preConditionSelect = document.getElementById('pre-condition-select');
const postConditionSelect = document.getElementById('post-condition-select');
const addPreConditionBtn = document.getElementById('add-pre-condition');
const addPostConditionBtn = document.getElementById('add-post-condition');
const preConditionsList = document.getElementById('pre-conditions-list');
const postConditionsList = document.getElementById('post-conditions-list');
const emptyPreConditions = document.getElementById('empty-pre-conditions');
const emptyPostConditions = document.getElementById('empty-post-conditions');

// Terminal Simulation
const terminalOutput = document.getElementById('terminal-output');
const terminalPrompt = document.getElementById('terminal-prompt');
const terminalInput = document.getElementById('terminal-input');

//  «»⁄ updateSelectedCount √Ê ÊŸ«∆› √Œ—Ï  Õ «Ã ≈÷«› Â« »‰«¡ ⁄·Ï „‘—Ê⁄ﬂ...

