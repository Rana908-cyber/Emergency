document.addEventListener('DOMContentLoaded', () => {
    const Modal = (modalId, openId, closeId) => {
        const modal = document.getElementById(modalId);
        const openBtn = document.getElementById(openId);
        const closeBtn = document.getElementById(closeId);

        if (openBtn && modal) {
            openBtn.onclick = () => modal.classList.add('active');
        }
        if (closeBtn && modal) {
            closeBtn.onclick = () => modal.classList.remove('active');
        }
    };

    Modal('emergencyModal', 'openModalBtn', 'closeModalBtn');
    Modal('teamModal', 'openTeamModalBtn', 'closeTeamModalBtn');
});