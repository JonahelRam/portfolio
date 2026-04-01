document.addEventListener('DOMContentLoaded', () => {
    // Gestion des filtres
    const filterButtons = document.querySelectorAll('.filter-btn');
    const projetCards = document.querySelectorAll('.projet-card');

    filterButtons.forEach(button => {
        button.addEventListener('click', () => {
            // Retirer la classe active de tous les boutons
            filterButtons.forEach(btn => btn.classList.remove('active'));
            // Ajouter la classe active au bouton cliqué
            button.classList.add('active');

            const filterValue = button.getAttribute('data-filter');

            projetCards.forEach(card => {
                if (filterValue === 'all' || card.getAttribute('data-category') === filterValue) {
                    card.style.display = 'block';
                } else {
                    card.style.display = 'none';
                }
            });
        });
    });

    // Gestion du modal
    const modal = document.getElementById('projetModal');
    const modalContent = modal.querySelector('.modal-body');
    const closeModal = modal.querySelector('.close-modal');
    const infoButtons = document.querySelectorAll('.projet-link i.fa-info-circle');

    // Données des projets
    const projetsData = {
        'projet1': {
            title: 'Application de Gestion de Tâches',
            description: 'Une application web moderne pour la gestion de projets et de tâches en équipe.',
            details: `
                <h2>Description détaillée</h2>
                <p>Cette application permet aux équipes de collaborer efficacement sur leurs projets en offrant les fonctionnalités suivantes :</p>
                <ul>
                    <li>Création et gestion de tâches</li>
                    <li>Attribution des tâches aux membres de l'équipe</li>
                    <li>Suivi de l'avancement en temps réel</li>
                    <li>Tableau de bord personnalisable</li>
                    <li>Notifications en temps réel</li>
                </ul>
                <h2>Technologies utilisées</h2>
                <ul>
                    <li>Frontend : React.js avec Redux pour la gestion d'état</li>
                    <li>Backend : Node.js avec Express</li>
                    <li>Base de données : MongoDB</li>
                    <li>Authentification : JWT</li>
                    <li>WebSocket pour les notifications en temps réel</li>
                </ul>
            `
        },
        'projet2': {
            title: 'Application Météo Mobile',
            description: 'Application mobile de prévisions météorologiques avec géolocalisation.',
            details: `
                <h2>Description détaillée</h2>
                <p>Une application mobile intuitive pour consulter la météo avec les fonctionnalités suivantes :</p>
                <ul>
                    <li>Prévisions météo sur 7 jours</li>
                    <li>Géolocalisation automatique</li>
                    <li>Alertes météo personnalisables</li>
                    <li>Widgets pour l'écran d'accueil</li>
                    <li>Mode hors ligne</li>
                </ul>
                <h2>Technologies utilisées</h2>
                <ul>
                    <li>React Native pour le développement cross-platform</li>
                    <li>Redux pour la gestion d'état</li>
                    <li>API OpenWeatherMap</li>
                    <li>AsyncStorage pour le stockage local</li>
                    <li>Geolocation API</li>
                </ul>
            `
        },
        'projet3': {
            title: 'Gestionnaire de Fichiers',
            description: 'Application desktop pour la gestion et l'organisation de fichiers.',
            details: `
                <h2>Description détaillée</h2>
                <p>Un gestionnaire de fichiers avancé avec les fonctionnalités suivantes :</p>
                <ul>
                    <li>Organisation automatique des fichiers par type</li>
                    <li>Recherche avancée avec filtres</li>
                    <li>Compression et décompression de fichiers</li>
                    <li>Prévisualisation des fichiers</li>
                    <li>Historique des actions</li>
                </ul>
                <h2>Technologies utilisées</h2>
                <ul>
                    <li>Python 3.x</li>
                    <li>PyQt6 pour l'interface graphique</li>
                    <li>SQLite pour le stockage des métadonnées</li>
                    <li>Pillow pour la manipulation d'images</li>
                    <li>Watchdog pour la surveillance des dossiers</li>
                </ul>
            `
        },
        'projet4': {
            title: 'Configuration Réseau Entreprise',
            description: 'Mise en place d'une infrastructure réseau sécurisée pour une PME.',
            details: `
                <h2>Description détaillée</h2>
                <p>Configuration complète d'un réseau d'entreprise avec les éléments suivants :</p>
                <ul>
                    <li>Mise en place de VLANs pour la segmentation du réseau</li>
                    <li>Configuration de VPN pour l'accès distant sécurisé</li>
                    <li>Mise en place d'un pare-feu</li>
                    <li>Configuration de la redondance</li>
                    <li>Monitoring du réseau</li>
                </ul>
                <h2>Technologies utilisées</h2>
                <ul>
                    <li>Équipements Cisco (Switch, Routeur, Firewall)</li>
                    <li>Protocoles : OSPF, BGP, VLAN</li>
                    <li>VPN : IPSec, SSL</li>
                    <li>Monitoring : PRTG</li>
                    <li>Sécurité : ACL, NAT, DMZ</li>
                </ul>
            `
        }
    };

    infoButtons.forEach(button => {
        button.addEventListener('click', (e) => {
            e.preventDefault();
            const projetCard = button.closest('.projet-card');
            const projetId = projetCard.getAttribute('data-category');
            const projetData = projetsData[projetId];

            if (projetData) {
                modalContent.innerHTML = projetData.details;
                modal.style.display = 'block';
            }
        });
    });

    closeModal.addEventListener('click', () => {
        modal.style.display = 'none';
    });

    window.addEventListener('click', (e) => {
        if (e.target === modal) {
            modal.style.display = 'none';
        }
    });
}); 