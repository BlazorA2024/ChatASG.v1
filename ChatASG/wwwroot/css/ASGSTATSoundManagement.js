
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
    soundToggle.innerHTML = soundEnabled ? '<i class="fas fa-volume-up"></i>' : '<i class="fas fa-volume-mute"></i>';
    soundToggle.classList.toggle('bg-gray-200');
    soundToggle.classList.toggle('bg-blue-100');
    soundToggle.classList.toggle('text-blue-600');
    playSound(clickSound);
        });

    function playSound(sound) {
            if (soundEnabled) {
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

    // Technique Management
    const techniqueSelect = document.getElementById('technique-select');
    const selectedTechniques = document.getElementById('selected-techniques');
    const emptyTechMessage = document.getElementById('empty-tech-message');
    const configureConditionsBtn = document.getElementById('configure-conditions');
    const selectedCount = document.getElementById('selected-count');

    // Scenario Generation
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

    // Sample data
    const techniquesData = {
        'nmap': {
        name: 'Nmap Scanning',
    tactic: 'Discovery',
    preconditions: ['IP: 192.168.0.1', 'Protocol: IPv4'],
    postconditions: ['Ports: SC', 'OS: SC'],
    color: 'bg-green-500'
            },
    'cve-exploit': {
        name: 'CVE-2016-3714 Exploit',
    tactic: 'Exploitation',
    preconditions: ['Ports: 80,443', 'OS: Linux'],
    postconditions: ['Shell: TEMPORAL'],
    color: 'bg-yellow-500'
            },
    'system-investigation': {
        name: 'System Investigation (Unix)',
    tactic: 'Discovery',
    preconditions: ['OS: SC', 'Shell: TEMPORAL'],
    postconditions: ['Privilege: UNDEFINED', 'Binaries: UNDEFINED'],
    color: 'bg-blue-500'
            },
    'download-wget': {
        name: 'Download (Wget)',
    tactic: 'Execution',
    preconditions: ['Shell: TEMPORAL', 'OS: Linux'],
    postconditions: ['Shell: PERMANENT'],
    color: 'bg-purple-500'
            },
    'privilege-escalation': {
        name: 'Privilege Escalation',
    tactic: 'Privilege Escalation',
    preconditions: ['Shell: PERMANENT', 'Privilege: User'],
    postconditions: ['Privilege: Superuser'],
    color: 'bg-red-500'
            },
    'lateral-movement': {
        name: 'Lateral Movement',
    tactic: 'Lateral Movement',
    preconditions: ['Privilege: Superuser'],
    postconditions: ['IP: NEW_TARGET'],
    color: 'bg-indigo-500'
            },
    'credential-dumping': {
        name: 'Credential Dumping',
    tactic: 'Credential Access',
    preconditions: ['Privilege: Superuser', 'OS: Windows'],
    postconditions: ['Credentials: EXTRACTED'],
    color: 'bg-pink-500'
            },
    'persistence': {
        name: 'Persistence Mechanism',
    tactic: 'Persistence',
    preconditions: ['Shell: PERMANENT'],
    postconditions: ['Persistence: ESTABLISHED'],
    color: 'bg-orange-500'
            }
        };

    // Current technique being configured in modal
    let currentTechniqueId = null;

    // Add log entry
    function addLogEntry(message, type = 'info', source = 'USER') {
            const entry = document.createElement('div');
    let icon = '';
    let borderColor = 'border-blue-600';

    switch (type) {
                case 'warning':
    icon = '<i class="fas fa-exclamation-triangle text-yellow-500 mr-2"></i>';
    borderColor = 'border-yellow-500';
    break;
    case 'error':
    icon = '<i class="fas fa-times-circle text-red-500 mr-2"></i>';
    borderColor = 'border-red-500';
    break;
    case 'success':
    icon = '<i class="fas fa-check-circle text-green-500 mr-2"></i>';
    borderColor = 'border-green-500';
    break;
    default:
    icon = '<i class="fas fa-info-circle text-blue-500 mr-2"></i>';
            }

    entry.className = `log-entry bg-gray-50 px-3 py-2 rounded mb-2 border-l-4 ${borderColor} fade-in`;
    entry.innerHTML = `
    <div class="flex items-start">
        ${icon}
        <span>${message}</span>
    </div>
    <div class="text-xs text-gray-500 mt-1 ml-4 mono">[${source}] ${new Date().toLocaleTimeString()}</div>
    `;

    operationLog.insertBefore(entry, operationLog.firstChild);

    // Auto-scroll if at bottom
    if (operationLog.scrollTop === 0) {
        operationLog.scrollTop = 0;
            }

    // Add to terminal
    addTerminalOutput(message, type);
        }

    // Add terminal output
    function addTerminalOutput(message, type = 'info') {
        let color = 'text-green-400';

    switch (type) {
                case 'warning':
    color = 'text-yellow-400';
    break;
    case 'error':
    color = 'text-red-400';
    break;
    case 'success':
    color = 'text-green-400';
    break;
    default:
    color = 'text-blue-400';
            }

    const output = document.createElement('div');
    output.className = `mb-1 ${color}`;
    output.innerHTML = message;

    terminalOutput.insertBefore(output, terminalPrompt);
        }

    // Simulate terminal typing
    function simulateTerminalTyping(commands, delay = 500) {
        let i = 0;
            const typeNext = () => {
                if (i < commands.length) {
        addTerminalOutput(`> ${commands[i]}`);
    i++;
    setTimeout(typeNext, delay);
                }
            };
    typeNext();
        }

        // Initialize terminal with some commands
        setTimeout(() => {
        simulateTerminalTyping([
            'check system --status',
            'load techniques --database=ics-attacks',
            'init scenario-generator --mode=state-based',
            'ready'
        ], 300);
        }, 1000);

        // Add state card
        addStateBtn.addEventListener('click', () => {
        playSound(clickSound);
    const field = stateField.value;
    let placeholder = '';
    let options = '';
    let inputType = 'text';

    switch (field) {
                case 'address':
    placeholder = 'e.g., 192.168.0.1';
    break;
    case 'protocol':
    placeholder = 'e.g., TCP, UDP, IPv4';
    break;
    case 'os':
    placeholder = 'e.g., Windows, Linux';
    break;
    case 'ports':
    placeholder = 'e.g., 80, 443, 22';
    inputType = 'number';
    break;
    case 'shell':
    options = `
    <option value="">Select shell type...</option>
    <option value="TEMPORAL">TEMPORAL</option>
    <option value="DOWNLOADED">DOWNLOADED</option>
    <option value="PERMANENT">PERMANENT</option>
    `;
    break;
    case 'privilege':
    options = `
    <option value="">Select privilege level...</option>
    <option value="user">Regular User</option>
    <option value="superuser">Superuser</option>
    `;
    break;
    case 'binaries':
    placeholder = 'e.g., /usr/bin/python, /bin/bash';
    break;
    case 'cwd':
    placeholder = 'e.g., /home/user, C:\\Users\\user';
    break;
    case 'misudo':
    placeholder = 'e.g., sudofind, sudovim';
    break;
            }

    const card = document.createElement('div');
    card.className = 'state-card bg-white border rounded-md p-3 shadow-sm fade-in';
    card.innerHTML = `
    <div class="flex justify-between items-center mb-1">
        <span class="text-xs font-medium uppercase text-gray-500">${field}</span>
        <button class="text-red-500 hover:text-red-700 text-xs remove-state transition">
            <i class="fas fa-times"></i>
        </button>
    </div>
    ${options ? `
                                <select class="w-full border border-gray-300 rounded px-2 py-1 text-sm focus:ring-blue-500 focus:border-blue-500">
                                    ${options}
                                </select>
                            ` : `
                                <input type="${inputType}" class="w-full border border-gray-300 rounded px-2 py-1 text-sm focus:ring-blue-500 focus:border-blue-500" placeholder="${placeholder}">
                            `}
    `;

    if (emptyStateMessage.style.display !== 'none') {
        emptyStateMessage.style.display = 'none';
            }

    stateCards.appendChild(card);

            // Add remove event
            card.querySelector('.remove-state').addEventListener('click', () => {
        playSound(clickSound);
    card.classList.add('opacity-0', 'transition-opacity', 'duration-300');
                setTimeout(() => {
        card.remove();
    updateStateCount();
    if (stateCards.children.length === 1) { // Only empty message left
        emptyStateMessage.style.display = 'block';
                    }
    addLogEntry(`Removed state field: ${field}`, 'info');
                }, 300);
            });

    updateStateCount();
    addLogEntry(`Added state field: ${field}`, 'info');
        });

    // Update state count display
    function updateStateCount() {
            const count = stateCards.querySelectorAll('.state-card').length;
    stateCount.textContent = `${count} field${count !== 1 ? 's' : ''} added`;
        }

        // Clear all states
        clearStatesBtn.addEventListener('click', () => {
        playSound(clickSound);
    const cards = stateCards.querySelectorAll('.state-card');
    if (cards.length === 0) return;

            cards.forEach(card => {
        card.classList.add('opacity-0', 'transition-opacity', 'duration-300');
                setTimeout(() => card.remove(), 300);
            });

            setTimeout(() => {
        emptyStateMessage.style.display = 'block';
    updateStateCount();
    addLogEntry('Cleared all state fields', 'warning');
            }, 350);
        });

        // Add technique to selected list
        techniqueSelect.addEventListener('change', (e) => {
            if (!e.target.value) return;

    playSound(clickSound);
    const techniqueId = e.target.value;
    const technique = techniquesData[techniqueId];

    // Check if already added
    if (document.querySelector(`[data-technique="${techniqueId}"]`)) {
        addLogEntry(`Technique "${technique.name}" is already selected`, 'warning');
    techniqueSelect.value = '';
    return;
            }

    const item = document.createElement('li');
    item.className = 'flex justify-between items-center bg-gray-100 p-2 rounded text-sm fade-in';
    item.dataset.technique = techniqueId;
    item.innerHTML = `
    <span class="font-medium">${technique.name}</span>
    <span class="text-xs bg-${technique.color.replace('bg-', '')} text-white px-2 py-1 rounded-full">${technique.tactic}</span>
    <div class="flex space-x-2">
        <button class="text-blue-500 hover:text-blue-700 edit-conditions transition" data-technique="${techniqueId}" title="Edit conditions">
            <i class="fas fa-edit"></i>
        </button>
        <button class="text-red-500 hover:text-red-700 remove-technique transition" title="Remove technique">
            <i class="fas fa-times"></i>
        </button>
    </div>
    `;

    if (emptyTechMessage.style.display !== 'none') {
        emptyTechMessage.style.display = 'none';
            }

    selectedTechniques.appendChild(item);
    techniqueSelect.value = '';

            // Add remove event
            item.querySelector('.remove-technique').addEventListener('click', () => {
        playSound(clickSound);
    item.classList.add('opacity-0', 'transition-opacity', 'duration-300');
                setTimeout(() => {
        item.remove();
    updateSelectedCount();
    if (selectedTechniques.children.length === 1) { // Only empty message left
        emptyTechMessage.style.display = 'block';
                    }
    addLogEntry(`Removed technique: ${technique.name}`, 'info');
                }, 300);
            });

            // Add edit conditions event
            item.querySelector('.edit-conditions').addEventListener('click', (e) => {
        playSound(clickSound);
    openConditionsModal(e.target.closest('button').dataset.technique);
            });

    updateSelectedCount();
    addLogEntry(`Added technique: ${technique.name} (${technique.tactic})`, 'info');
        });

    // Update selected techniques count
    function updateSelectedCount() {
            const count = selectedTechniques.querySelectorAll('li[data-technique]').length;
    selectedCount.textContent = `${count} selected`;
        }

        // Configure conditions button
        configureConditionsBtn.addEventListener('click', () => {
        playSound(clickSound);
    if (selectedTechniques.children.length === 1) { // Only empty message
        addLogEntry('Please select at least one technique first', 'warning');
    return;
            }

    // Open modal with first technique
    openConditionsModal(document.querySelector('#selected-techniques li').dataset.technique);
        });

    // Open conditions modal
    function openConditionsModal(techniqueId) {
        currentTechniqueId = techniqueId;
    const technique = techniquesData[techniqueId];

    modalTechName.textContent = technique.name;

    // Clear existing conditions
    preConditionsList.innerHTML = '';
    postConditionsList.innerHTML = '';

            // Add technique's preconditions
            if (technique.preconditions && technique.preconditions.length > 0) {
        emptyPreConditions.style.display = 'none';
                technique.preconditions.forEach(cond => {
        addConditionToModal(cond, true);
                });
            } else {
        emptyPreConditions.style.display = 'block';
            }

            // Add technique's postconditions
            if (technique.postconditions && technique.postconditions.length > 0) {
        emptyPostConditions.style.display = 'none';
                technique.postconditions.forEach(cond => {
        addConditionToModal(cond, false);
                });
            } else {
        emptyPostConditions.style.display = 'block';
            }

    conditionsModal.classList.remove('hidden');
    document.body.classList.add('overflow-hidden');

    addLogEntry(`Opened conditions editor for: ${technique.name}`, 'info');
        }

    // Add condition to modal list
    function addConditionToModal(condition, isPrecondition) {
            const list = isPrecondition ? preConditionsList : postConditionsList;
    const emptyMessage = isPrecondition ? emptyPreConditions : emptyPostConditions;

    if (emptyMessage.style.display !== 'none') {
        emptyMessage.style.display = 'none';
            }

    const item = document.createElement('div');
    item.className = 'flex justify-between items-center bg-gray-50 p-2 rounded border border-gray-200 text-sm';
    item.innerHTML = `
    <span>${condition}</span>
    <button class="text-red-500 hover:text-red-700 remove-condition transition">
        <i class="fas fa-times"></i>
    </button>
    `;

            item.querySelector('.remove-condition').addEventListener('click', () => {
        playSound(clickSound);
    item.classList.add('opacity-0', 'transition-opacity', 'duration-300');
                setTimeout(() => {
        item.remove();
    if (list.children.length === 0) {
        emptyMessage.style.display = 'block';
                    }
                }, 300);
            });

    list.appendChild(item);
        }

        // Add pre-condition
        addPreConditionBtn.addEventListener('click', () => {
        playSound(clickSound);
    const value = preConditionSelect.value;
    if (!value) return;

    const condition = `${value.charAt(0).toUpperCase() + value.slice(1)}: ${value === 'os' ? 'Linux' : '192.168.0.1'}`;
    addConditionToModal(condition, true);
    preConditionSelect.value = '';
        });

        // Add post-condition
        addPostConditionBtn.addEventListener('click', () => {
        playSound(clickSound);
    const value = postConditionSelect.value;
    if (!value) return;

    const condition = value.includes(':') ? value : `${value}: SET`;
    addConditionToModal(condition, false);
    postConditionSelect.value = '';
        });

    // Close modal
    function closeModal() {
        playSound(clickSound);
    conditionsModal.classList.add('hidden');
    document.body.classList.remove('overflow-hidden');
    currentTechniqueId = null;
        }

    closeModalBtn.addEventListener('click', closeModal);
    cancelConditionsBtn.addEventListener('click', closeModal);

        // Save conditions
        saveConditionsBtn.addEventListener('click', () => {
        playSound(clickSound);
    if (!currentTechniqueId) return;

    // Get all preconditions
    const preconditions = [];
    const preItems = preConditionsList.querySelectorAll('div:not(#empty-pre-conditions)');
            preItems.forEach(item => {
        preconditions.push(item.querySelector('span').textContent);
            });

    // Get all postconditions
    const postconditions = [];
    const postItems = postConditionsList.querySelectorAll('div:not(#empty-post-conditions)');
            postItems.forEach(item => {
        postconditions.push(item.querySelector('span').textContent);
            });

    // Update technique data
    techniquesData[currentTechniqueId].preconditions = preconditions;
    techniquesData[currentTechniqueId].postconditions = postconditions;

    addLogEntry(`Saved conditions for: ${techniquesData[currentTechniqueId].name}`, 'success');
    closeModal();
        });

        // Tab switching
        tabButtons.forEach(button => {
        button.addEventListener('click', () => {
            playSound(clickSound);
            // Remove active class from all buttons and contents
            tabButtons.forEach(btn => {
                btn.classList.remove('text-blue-600', 'border-blue-600');
                btn.classList.add('text-gray-600', 'hover:text-blue-600');
            });
            tabContents.forEach(content => content.classList.remove('active'));

            // Add active class to clicked button and corresponding content
            button.classList.add('text-blue-600', 'border-blue-600');
            button.classList.remove('text-gray-600', 'hover:text-blue-600');
            document.getElementById(`${button.dataset.tab}-tab`).classList.add('active');
        });
        });

        // Generate scenarios
        generateScenariosBtn.addEventListener('click', () => {
        playSound(generateSound);
    if (stateCards.children.length === 1) { // Only empty message
        addLogEntry('Please add at least one state first', 'warning');
    return;
            }

    if (selectedTechniques.children.length === 1) { // Only empty message
        addLogEntry('Please select at least one technique first', 'warning');
    return;
            }

    // Show loading state
    generateScenariosBtn.innerHTML = '<i class="fas fa-spinner fa-spin mr-2"></i> Generating...';
    generateScenariosBtn.classList.add('cursor-not-allowed');

            // Simulate generation delay
            setTimeout(() => {
        // Update scenario results
        scenarioResults.innerHTML = `
                                <div class="bg-green-50 border border-green-200 rounded-md p-3 mb-3 fade-in">
                                    <div class="flex justify-between items-start">
                                        <div>
                                            <h4 class="font-medium text-green-800 mb-1">Scenario 1: Initial Access to Privilege Escalation</h4>
                                            <p class="text-xs text-green-600">Generated from 3 techniques and 5 state conditions</p>
                                        </div>
                                        <span class="text-xs bg-green-100 text-green-800 px-2 py-1 rounded-full">New</span>
                                    </div>
                                    <div class="mt-2 flex flex-wrap gap-1">
                                        <span class="text-xs bg-green-100 text-green-800 px-2 py-1 rounded-full">Discovery</span>
                                        <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-1 rounded-full">Exploitation</span>
                                        <span class="text-xs bg-red-100 text-red-800 px-2 py-1 rounded-full">Privilege Escalation</span>
                                    </div>
                                </div>
                                <div class="bg-blue-50 border border-blue-200 rounded-md p-3 fade-in">
                                    <div class="flex justify-between items-start">
                                        <div>
                                            <h4 class="font-medium text-blue-800 mb-1">Scenario 2: Lateral Movement Path</h4>
                                            <p class="text-xs text-blue-600">Generated from 4 techniques and 7 state conditions</p>
                                        </div>
                                        <span class="text-xs bg-blue-100 text-blue-800 px-2 py-1 rounded-full">New</span>
                                    </div>
                                    <div class="mt-2 flex flex-wrap gap-1">
                                        <span class="text-xs bg-green-100 text-green-800 px-2 py-1 rounded-full">Discovery</span>
                                        <span class="text-xs bg-purple-100 text-purple-800 px-2 py-1 rounded-full">Execution</span>
                                        <span class="text-xs bg-indigo-100 text-indigo-800 px-2 py-1 rounded-full">Lateral Movement</span>
                                    </div>
                                </div>
                            `;

    // Update sequence view
    scenarioSequence.innerHTML = `
    <li class="text-gray-800 fade-in">1. Nmap Scanning <span class="text-xs bg-green-100 text-green-800 px-2 py-0.5 rounded-full ml-2">Discovery</span></li>
    <li class="text-gray-800 fade-in">2. CVE-2016-3714 Exploit <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-0.5 rounded-full ml-2">Exploitation</span></li>
    <li class="text-gray-800 fade-in">3. System Investigation <span class="text-xs bg-blue-100 text-blue-800 px-2 py-0.5 rounded-full ml-2">Discovery</span></li>
    <li class="text-gray-800 fade-in">4. Download (Wget) <span class="text-xs bg-purple-100 text-purple-800 px-2 py-0.5 rounded-full ml-2">Execution</span></li>
    <li class="text-gray-800 fade-in">5. Privilege Escalation <span class="text-xs bg-red-100 text-red-800 px-2 py-0.5 rounded-full ml-2">Privilege Escalation</span></li>
    `;

    // Render graph visualization
    renderAttackGraph();

    // Update scenario count
    scenarioCount.textContent = '2 scenarios';

    // Reset button state
    generateScenariosBtn.innerHTML = '<i class="fas fa-play mr-2"></i> Generate Scenarios';
    generateScenariosBtn.classList.remove('cursor-not-allowed');

    addLogEntry('Generated 2 attack scenarios', 'success');
    addLogEntry('Scenario 1: Initial Access ? Privilege Escalation', 'info', 'SCENARIO');
    addLogEntry('Scenario 2: Lateral Movement Path', 'info', 'SCENARIO');

    // Enable validate button
    validateScenariosBtn.classList.remove('opacity-50', 'cursor-not-allowed');
            }, 1500);
        });

        // Validate scenarios
        validateScenariosBtn.addEventListener('click', () => {
        playSound(validateSound);
    if (scenarioResults.textContent.includes('No scenarios generated yet')) {
        addLogEntry('Please generate scenarios first', 'warning');
    return;
            }

    // Show loading state
    validateScenariosBtn.innerHTML = '<i class="fas fa-spinner fa-spin mr-2"></i> Validating...';
    validateScenariosBtn.classList.add('cursor-not-allowed');

            // Simulate validation delay
            setTimeout(() => {
        // Update validation results
        validationResults.innerHTML = `
                                <div class="mb-4 fade-in">
                                    <h4 class="font-medium text-gray-800 mb-2 flex items-center">
                                        <i class="fas fa-chart-bar mr-2 text-blue-600"></i> Comparison with ICS Incidents
                                    </h4>
                                    <div class="flex items-center text-sm mt-2">
                                        <div class="w-1/2">
                                            <p class="text-gray-600">Match with known incidents:</p>
                                        </div>
                                        <div class="w-1/2">
                                            <div class="flex items-center">
                                                <div class="w-full bg-gray-200 rounded-full h-2.5">
                                                    <div class="bg-green-600 h-2.5 rounded-full" style="width: 78%"></div>
                                                </div>
                                                <span class="ml-2 text-gray-700">78%</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="fade-in">
                                    <h4 class="font-medium text-gray-800 mb-2 flex items-center">
                                        <i class="fas fa-bug mr-2 text-red-600"></i> Closest Match
                                    </h4>
                                    <div class="bg-yellow-50 border border-yellow-200 rounded-md p-3">
                                        <div class="flex justify-between items-start mb-1">
                                            <h5 class="font-medium text-yellow-800">PoetRAT Attack Pattern</h5>
                                            <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-1 rounded-full">High Confidence</span>
                                        </div>
                                        <p class="text-xs text-yellow-700">Similarity: 78% | MITRE Technique: T1059.003</p>
                                        <div class="mt-2 flex flex-wrap gap-1">
                                            <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-1 rounded-full">Command-Line Interface</span>
                                            <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-1 rounded-full">Persistence</span>
                                            <span class="text-xs bg-yellow-100 text-yellow-800 px-2 py-1 rounded-full">Lateral Movement</span>
                                        </div>
                                    </div>
                                </div>
                            `;

    // Show validation tab
    tabButtons[2].click();

    // Update validation count
    validCount.textContent = '1 validated';
    validCount.classList.remove('hidden');

    // Reset button state
    validateScenariosBtn.innerHTML = '<i class="fas fa-check-circle mr-2"></i> Validate Scenarios';
    validateScenariosBtn.classList.remove('cursor-not-allowed');

    addLogEntry('Validated scenarios against ICS incident database', 'success');
    addLogEntry('Closest match: PoetRAT Attack Pattern (78% similarity)', 'info', 'VALIDATION');
            }, 1500);
        });

        // Clear operation logs
        clearLogsBtn.addEventListener('click', () => {
        playSound(clickSound);
    operationLog.innerHTML = `
    <div class="log-entry bg-gray-50 px-3 py-2 rounded">
        <div class="flex items-start">
            <span class="text-blue-600 mr-2">></span>
            <span>Logs cleared. System ready.</span>
        </div>
        <div class="text-xs text-gray-500 mt-1 ml-4">[SYSTEM] ${new Date().toLocaleTimeString()}</div>
    </div>
    `;

            addTerminalOutput('> logs --clear');
    addTerminalOutput('Logs cleared successfully');
        });

    // Render attack graph visualization
    function renderAttackGraph() {
        graphSvg.innerHTML = '';

    // Sample nodes data
    const nodes = [
    {id: 'state', name: 'Initial State', type: 'state', x: 100, y: 150, color: 'gray' },
    {id: 'nmap', name: 'Nmap', type: 'technique', x: 250, y: 80, color: 'green', tactic: 'Discovery' },
    {id: 'cve', name: 'CVE Exploit', type: 'technique', x: 400, y: 50, color: 'yellow', tactic: 'Exploitation' },
    {id: 'investigation', name: 'System Inv.', type: 'technique', x: 400, y: 150, color: 'blue', tactic: 'Discovery' },
    {id: 'download', name: 'Download', type: 'technique', x: 550, y: 100, color: 'purple', tactic: 'Execution' },
    {id: 'privilege', name: 'Priv. Esc.', type: 'technique', x: 700, y: 50, color: 'red', tactic: 'Privilege Escalation' },
    {id: 'lateral', name: 'Lateral Mov.', type: 'technique', x: 700, y: 150, color: 'indigo', tactic: 'Lateral Movement' },
    {id: 'end', name: 'End State', type: 'state', x: 850, y: 150, color: 'gray' }
    ];

    // Sample connections
    const connections = [
    {from: 'state', to: 'nmap' },
    {from: 'nmap', to: 'cve' },
    {from: 'nmap', to: 'investigation' },
    {from: 'cve', to: 'download' },
    {from: 'investigation', to: 'download' },
    {from: 'download', to: 'privilege' },
    {from: 'download', to: 'lateral' },
    {from: 'privilege', to: 'end' },
    {from: 'lateral', to: 'end' }
    ];

            // Draw connections first (so they appear under nodes)
            connections.forEach(conn => {
                const fromNode = nodes.find(n => n.id === conn.from);
                const toNode = nodes.find(n => n.id === conn.to);

    if (fromNode && toNode) {
                    const line = document.createElementNS('http://www.w3.org/2000/svg', 'line');
    line.setAttribute('x1', fromNode.x);
    line.setAttribute('y1', fromNode.y);
    line.setAttribute('x2', toNode.x);
    line.setAttribute('y2', toNode.y);
    line.setAttribute('stroke', '#94a3b8');
    line.setAttribute('stroke-width', '2');
    line.setAttribute('stroke-dasharray', '5');
    line.setAttribute('class', 'connection');
    graphSvg.appendChild(line);

    // Add arrowhead
    const angle = Math.atan2(toNode.y - fromNode.y, toNode.x - fromNode.x);
    const arrowSize = 8;
    const arrowX = toNode.x - 20 * Math.cos(angle);
    const arrowY = toNode.y - 20 * Math.sin(angle);

    const arrow = document.createElementNS('http://www.w3.org/2000/svg', 'polygon');
    arrow.setAttribute('points', `0,0 ${arrowSize},${arrowSize / 2} 0,${arrowSize}`);
    arrow.setAttribute('transform', `translate(${arrowX},${arrowY}) rotate(${angle * 180 / Math.PI})`);
    arrow.setAttribute('fill', '#94a3b8');
    graphSvg.appendChild(arrow);
                }
            });

            // Create nodes
            nodes.forEach(node => {
                // Node circle
                const circle = document.createElementNS('http://www.w3.org/2000/svg', 'circle');
    circle.setAttribute('cx', node.x);
    circle.setAttribute('cy', node.y);
    circle.setAttribute('r', node.type === 'state' ? 20 : 25);
    circle.setAttribute('fill', node.color);
    circle.setAttribute('class', 'node');
    graphSvg.appendChild(circle);

    // Node text
    const text = document.createElementNS('http://www.w3.org/2000/svg', 'text');
    text.setAttribute('x', node.x);
    text.setAttribute('y', node.y + 5);
    text.setAttribute('text-anchor', 'middle');
    text.setAttribute('fill', 'white');
    text.setAttribute('font-size', '10');
    text.setAttribute('font-weight', 'bold');
    text.setAttribute('font-family', 'Inter');
    text.textContent = node.name;
    graphSvg.appendChild(text);

    // Add tactic for technique nodes
    if (node.tactic) {
                    const tacticText = document.createElementNS('http://www.w3.org/2000/svg', 'text');
    tacticText.setAttribute('x', node.x);
    tacticText.setAttribute('y', node.y + (node.type === 'state' ? 30 : 35));
    tacticText.setAttribute('text-anchor', 'middle');
    tacticText.setAttribute('fill', node.color);
    tacticText.setAttribute('font-size', '8');
    tacticText.setAttribute('font-family', 'Inter');
    tacticText.textContent = node.tactic;
    graphSvg.appendChild(tacticText);
                }
            });
        }

    // Initialize validate button as disabled
    validateScenariosBtn.classList.add('opacity-50', 'cursor-not-allowed');

    // Add initial log entries
    addLogEntry('Welcome to CyberShield Attack Scenario Generator', 'info', 'SYSTEM');
    addLogEntry('Loading system modules...', 'info', 'SYSTEM');
    addLogEntry('Ready to configure attack scenarios', 'success', 'SYSTEM');
