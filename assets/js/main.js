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
    Modal('profileModal', 'openProfileBtn', 'closeProfileBtn');
});


const loginForm = document.querySelector('form');
if (loginForm) {
    loginForm.addEventListener('submit', (e) => {
        e.preventDefault();
        const role = document.getElementById('role').value;

        localStorage.setItem('userRole', role);

       
        if (role === 'admin') {
            window.location.href = 'Admin/dashboard.html'
        } else if (role === 'team') {
            window.location.href = 'team/dashboard.html';
        } else if (role === 'citizen') {
            window.location.href = 'citizen/dashboard.html';
        }
    });
}